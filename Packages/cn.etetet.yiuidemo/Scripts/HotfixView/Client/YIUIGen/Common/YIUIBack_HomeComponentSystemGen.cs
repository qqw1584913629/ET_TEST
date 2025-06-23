using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;

namespace ET.Client
{
    /// <summary>
    /// 由YIUI工具自动创建 请勿修改
    /// </summary>
    [FriendOf(typeof(YIUIChild))]
    [EntitySystemOf(typeof(YIUIBack_HomeComponent))]
    public static partial class YIUIBack_HomeComponentSystem
    {
        [EntitySystem]
        private static void Awake(this YIUIBack_HomeComponent self)
        {
        }

        [EntitySystem]
        private static void YIUIBind(this YIUIBack_HomeComponent self)
        {
            self.UIBind();
        }

        private static void UIBind(this YIUIBack_HomeComponent self)
        {
            self.u_UIBase = self.GetParent<YIUIChild>();

            self.u_EventClose = self.UIBase.EventTable.FindEvent<UITaskEventP0>("u_EventClose");
            self.u_EventCloseHandle = self.u_EventClose.Add(self,YIUIBack_HomeComponent.OnEventCloseInvoke);

        }
    }
}
