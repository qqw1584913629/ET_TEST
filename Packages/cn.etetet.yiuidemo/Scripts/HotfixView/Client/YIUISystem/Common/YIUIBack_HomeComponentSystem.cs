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
    [FriendOf(typeof(YIUIBack_HomeComponent))]
    public static partial class YIUIBack_HomeComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this YIUIBack_HomeComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this YIUIBack_HomeComponent self)
        {
        }

        #region YIUIEvent开始
        
        [YIUIInvoke(YIUIBack_HomeComponent.OnEventCloseInvoke)]
        private static async ETTask OnEventCloseInvoke(this YIUIBack_HomeComponent self)
        {
            self.YIUIMgr().HomePanel<MainPanelComponent>().NoContext();
            await ETTask.CompletedTask;
        }
        #endregion YIUIEvent结束
    }
}
