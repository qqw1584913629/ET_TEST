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
            self.u_DataIcon.SetValue(data.Icon);
            self.u_DataItemName.SetValue(data.Name);
            self.u_DataIsAd.SetValue(data.IsAd);
            self.u_DataIsPopular.SetValue(data.IsPopular);
            self.u_DataPrice.SetValue(data.Price);
        }
        public static void Select(this Item_ChestComponent self, bool select)
        {
            self.u_DataIsSelect.SetValue(select);
        }

        #region YIUIEvent开始
        
        #endregion YIUIEvent结束
    }
}
