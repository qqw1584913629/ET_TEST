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
    [FriendOf(typeof(LoginViewComponent))]
    public static partial class LoginViewComponentSystem
    {
        [EntitySystem]
        private static void YIUIInitialize(this LoginViewComponent self)
        {
        }

        [EntitySystem]
        private static void Destroy(this LoginViewComponent self)
        {
        }

        [EntitySystem]
        private static async ETTask<bool> YIUIOpen(this LoginViewComponent self)
        {
            await ETTask.CompletedTask;
            return true;
        }

        #region YIUIEvent开始
        
        [YIUIInvoke(LoginViewComponent.OnEventLoginInvoke)]
        private static async ETTask OnEventLoginInvoke(this LoginViewComponent self)
        {
            Log.Info($"登录");
            GlobalComponent globalComponent = self.Root().GetComponent<GlobalComponent>();
            await LoginHelper.Login(self.Root(),
                globalComponent.GlobalConfig.Address,
                self.u_ComInputFieldAccountTMP_InputField.text,
                self.u_ComInputFieldPasswordTMP_InputField.text);
        }
        
        [YIUIInvoke(LoginViewComponent.OnEventSignupInvoke)]
        private static async ETTask OnEventSignupInvoke(this LoginViewComponent self)
        {
            self.UIView.GetPanelComponent().OpenViewAsync<LoginSignUpViewComponent>().NoContext();
            await ETTask.CompletedTask;
        }
        #endregion YIUIEvent结束
    }
}
