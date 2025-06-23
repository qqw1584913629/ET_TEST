using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;

namespace ET.Client
{
    /// <summary>
    /// Author  YIUI
    /// Date    2025.6.23
    /// Desc
    /// </summary>
    [FriendOf(typeof(ShopGoldViewComponent))]
    public static partial class ShopGoldViewComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this ShopGoldViewComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this ShopGoldViewComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this ShopGoldViewComponent self)
        {
            await ETTask.CompletedTask;
            return true;
        }

        #region YIUIEvent开始
        #endregion YIUIEvent结束
    }
}
