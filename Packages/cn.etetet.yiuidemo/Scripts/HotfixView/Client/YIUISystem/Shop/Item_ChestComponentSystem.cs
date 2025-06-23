using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;

namespace ET.Client
{
    /// <summary>
    /// Author  zyh
    /// Date    2025.6.23
    /// Desc
    /// </summary>
    [FriendOf(typeof(Item_ChestComponent))]
    public static partial class Item_ChestComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this Item_ChestComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this Item_ChestComponent self)
        {
        }
        
        public static void Refresh(this Item_ChestComponent self, ShopItemData data)
        {
        }
        public static void Select(this Item_ChestComponent self, bool select)
        {
        }

        #region YIUIEvent开始
        #endregion YIUIEvent结束
    }
}
