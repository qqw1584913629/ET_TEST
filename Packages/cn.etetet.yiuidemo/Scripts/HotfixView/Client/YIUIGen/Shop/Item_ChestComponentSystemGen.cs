using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;

namespace ET.Client
{
    /// <summary>
    /// 由YIUI工具自动创建 请勿修改
    /// </summary>
    [FriendOf(typeof(YIUIChild))]
    [EntitySystemOf(typeof(Item_ChestComponent))]
    public static partial class Item_ChestComponentSystem
    {
        [EntitySystem]
        private static void Awake(this Item_ChestComponent self)
        {
        }

        [EntitySystem]
        private static void YIUIBind(this Item_ChestComponent self)
        {
            self.UIBind();
        }

        private static void UIBind(this Item_ChestComponent self)
        {
            self.u_UIBase = self.GetParent<YIUIChild>();


        }
    }
}
