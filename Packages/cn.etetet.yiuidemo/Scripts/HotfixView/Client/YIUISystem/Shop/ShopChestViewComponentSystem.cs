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
                new ShopItemData() { Name = "Item1", Price = 100, IsAd = false, IsPopular = false, Icon = 1 },
                new ShopItemData() { Name = "Item2", Price = 200, IsAd = true, IsPopular = false, Icon = 2 },
                new ShopItemData() { Name = "Item3", Price = 300, IsAd = false, IsPopular = true, Icon = 3 },
                new ShopItemData() { Name = "Item4", Price = 400, IsAd = true, IsPopular = true, Icon = 4 },
                new ShopItemData() { Name = "Item5", Price = 500, IsAd = false, IsPopular = false, Icon = 5 },
                new ShopItemData() { Name = "Item6", Price = 600, IsAd = true, IsPopular = false, Icon = 6 },
                new ShopItemData() { Name = "Item7", Price = 700, IsAd = false, IsPopular = true, Icon = 7 },
                new ShopItemData() { Name = "Item8", Price = 800, IsAd = true, IsPopular = true, Icon = 8 },
                new ShopItemData() { Name = "Item9", Price = 900, IsAd = false, IsPopular = false, Icon = 9 },
                new ShopItemData() { Name = "Item10", Price = 1000, IsAd = true, IsPopular = false, Icon = 10 },
                new ShopItemData() { Name = "Item11", Price = 1100, IsAd = false, IsPopular = true, Icon = 11 },
                new ShopItemData() { Name = "Item12", Price = 1200, IsAd = true, IsPopular = true, Icon = 12 },
                new ShopItemData() { Name = "Item13", Price = 1300, IsAd = false, IsPopular = false, Icon = 13 },
                new ShopItemData() { Name = "Item14", Price = 1400, IsAd = true, IsPopular = false, Icon = 14 },
            };
            self.u_LoopScrollChild = self.AddChild<YIUILoopScrollChild, LoopScrollRect, Type, string>(self.u_ComLoopScrollHorizontal_ChestLoopHorizontalScrollRect,
            typeof(Item_ChestComponent),
            "u_EventSelect");
        }
        [EntitySystem]
        public static void YIUILoopRenderer(this ShopChestViewComponent self, Item_ChestComponent item, ShopItemData data, int index, bool select)
        {
            // item.Refresh(data);
            // item.Select(select);
        }
        [EntitySystem]
        public static void YIUILoopOnClick(this ShopChestViewComponent self, Item_ChestComponent item, ShopItemData data, int index, bool select)
        {
            // item.Select(select);
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
