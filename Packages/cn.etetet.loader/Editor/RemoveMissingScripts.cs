using UnityEngine;
using UnityEditor;

namespace ET
{
    public class RemoveMissingScripts
    {
        [MenuItem("GameObject/清除失效脚本", false, 49)]
        private static void RemoveMissingScriptsFromSelection()
        {
            GameObject[] selectedObjects = Selection.gameObjects;
            if (selectedObjects.Length == 0)
            {
                EditorUtility.DisplayDialog("提示", "请先选择一个游戏对象！", "确定");
                return;
            }

            int totalRemovedCount = 0;
            foreach (GameObject obj in selectedObjects)
            {
                int count = RemoveMissingScriptsRecursively(obj);
                totalRemovedCount += count;
            }

            if (totalRemovedCount > 0)
            {
                Debug.Log($"清除完成！共移除 {totalRemovedCount} 个失效脚本。");
                EditorUtility.DisplayDialog("完成", $"清除完成！共移除 {totalRemovedCount} 个失效脚本。", "确定");
            }
            else
            {
                EditorUtility.DisplayDialog("完成", "没有发现失效脚本。", "确定");
            }
        }

        private static int RemoveMissingScriptsRecursively(GameObject obj)
        {
            int count = 0;

            // 获取当前对象上的所有组件
            Component[] components = obj.GetComponents<Component>();
            
            // 记录原始状态以便撤销
            Undo.RecordObject(obj, "Remove Missing Scripts");

            // 检查并移除失效脚本
            for (int i = 0; i < components.Length; i++)
            {
                if (components[i] == null)
                {
                    count += GameObjectUtility.RemoveMonoBehavioursWithMissingScript(obj);
                    break; // 一旦找到一个失效脚本并清理，就跳出循环
                }
            }

            // 递归处理所有子对象
            foreach (Transform child in obj.transform)
            {
                count += RemoveMissingScriptsRecursively(child.gameObject);
            }

            return count;
        }
    }
}