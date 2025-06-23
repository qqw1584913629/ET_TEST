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
    [FriendOf(typeof(ShopGemViewComponent))]
    public static partial class ShopGemViewComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this ShopGemViewComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this ShopGemViewComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this ShopGemViewComponent self)
        {
            await ETTask.CompletedTask;
            return true;
        }

        #region YIUIEvent开始
        #endregion YIUIEvent结束
    }
}
