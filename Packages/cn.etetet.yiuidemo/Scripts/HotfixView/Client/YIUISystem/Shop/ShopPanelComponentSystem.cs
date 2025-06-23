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
    [FriendOf(typeof(ShopPanelComponent))]
    public static partial class ShopPanelComponentSystem
    {
        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this ET.Client.ShopPanelComponent self, ET.Client.EShopPanelViewEnum param1)
        {
            self.u_DataCurrentSelect.SetValue((int)param1);
            await ETTask.CompletedTask;
            return true;
        }
        [EntitySystem]
        private static void YIUIInitialize(this ShopPanelComponent self)
        {
            self.u_DataCurrentSelect.AddValueChangeAction(self.OnDataCurrentSelectChange);
        }

        [EntitySystem]
        private static void Destroy(this ShopPanelComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this ShopPanelComponent self)
        {
            self.u_DataCurrentSelect.SetValue(1);
            await ETTask.CompletedTask;
            return true;
        }
        private static void OnDataCurrentSelectChange(this ShopPanelComponent self, int newValue, int oldValue)
        {
            self.UIPanel.OpenViewAsync(((EShopPanelViewEnum)newValue).ToString()).NoContext();
        }

        #region YIUIEvent开始
        #endregion YIUIEvent结束
    }
}
