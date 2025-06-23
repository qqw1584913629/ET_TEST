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
    [FriendOf(typeof(ShopChestViewComponent))]
    public static partial class ShopChestViewComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this ShopChestViewComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this ShopChestViewComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this ShopChestViewComponent self)
        {
            await ETTask.CompletedTask;
            return true;
        }

        #region YIUIEvent开始
        #endregion YIUIEvent结束
    }
}
