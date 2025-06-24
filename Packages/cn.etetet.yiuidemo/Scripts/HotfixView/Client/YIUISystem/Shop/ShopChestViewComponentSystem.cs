using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;
using UnityEngine.UI;

namespace ET.Client
{
    /// <summary>
    /// Author  zyh
    /// Date    2025.6.23
    /// Desc
    /// </summary>
    [FriendOf(typeof(ShopChestViewComponent))]
    public static partial class ShopChestViewComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this ShopChestViewComponent self)
        {
            self.ShopItemDataList = new List<ShopItemData>()
            {
                new ShopItemData() { Name = "Item1", Price = 100, IsAd = false, IsPopular = false, Icon = "Chest_Close_m_01" },
                new ShopItemData() { Name = "Item2", Price = 200, IsAd = true, IsPopular = false, Icon = "Chest_Close_m_02" },
                new ShopItemData() { Name = "Item3", Price = 300, IsAd = false, IsPopular = true, Icon = "Chest_Close_m_03" },
                new ShopItemData() { Name = "Item4", Price = 400, IsAd = true, IsPopular = true, Icon = "Chest_Close_m_04" },
                new ShopItemData() { Name = "Item5", Price = 500, IsAd = false, IsPopular = false, Icon = "Chest_Close_m_05" },
            };
            self.u_LoopScrollChild = self.AddChild<YIUILoopScrollChild, LoopScrollRect, Type, string>(self.u_ComLoopScrollHorizontal_ChestLoopHorizontalScrollRect,
            typeof(Item_ChestComponent),
            "u_EventSelect");
        }
        [EntitySystem]
        public static void YIUILoopRenderer(this ShopChestViewComponent self, Item_ChestComponent item, ShopItemData data, int index, bool select)
        {
            item.Refresh(data);
            item.Select(select);
        }
        [EntitySystem]
        public static void YIUILoopOnClick(this ShopChestViewComponent self, Item_ChestComponent item, ShopItemData data, int index, bool select)
        {
            item.Select(select);
        }

        [EntitySystem]
        private static void Destroy(this ShopChestViewComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this ShopChestViewComponent self)
        {
            self.LoopScrollChild.ClearSelect();
            await self.LoopScrollChild.SetDataRefresh(self.ShopItemDataList, 0);
            await ETTask.CompletedTask;
            return true;
        }

        #region YIUIEvent开始
        #endregion YIUIEvent结束
    }
}
