using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;

namespace ET.Client
{
    /// <summary>
    /// Author  YIUI
    /// Date    2025.6.21
    /// Desc
    /// </summary>
    [FriendOf(typeof(LoginSignUpViewComponent))]
    public static partial class LoginSignUpViewComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this LoginSignUpViewComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this LoginSignUpViewComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this LoginSignUpViewComponent self)
        {
            await ETTask.CompletedTask;
            return true;
        }

        #region YIUIEvent开始
        
        [YIUIInvoke(LoginSignUpViewComponent.OnEventCloseInvoke)]
        private static async ETTask OnEventCloseInvoke(this LoginSignUpViewComponent self)
        {
            self.UIView.GetPanelComponent().OpenViewAsync<LoginViewComponent>().NoContext();
            await ETTask.CompletedTask;
        }
        #endregion YIUIEvent结束
    }
}
