using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;

namespace ET.Client
{
    [FriendOf(typeof(MainPanelComponent))]
    public static partial class MainPanelComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this MainPanelComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this MainPanelComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this MainPanelComponent self)
        {
            await ETTask.CompletedTask;
            return true;
        }

        #region YIUIEvent开始
        
        [YIUIInvoke(MainPanelComponent.OnEventOpenShopInvoke)]
        private static async ETTask OnEventOpenShopInvoke(this MainPanelComponent self)
        {
            self.YIUISceneRoot().OpenPanelAsync<ShopPanelComponent>().NoContext();
            await ETTask.CompletedTask;
        }
        #endregion YIUIEvent结束
    }
}
