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
    [FriendOf(typeof(YIUIWindowComponent))]
    [FriendOf(typeof(YIUIPanelComponent))]
    [EntitySystemOf(typeof(ShopPanelComponent))]
    public static partial class ShopPanelComponentSystem
    {
        [EntitySystem]
        private static void Awake(this ShopPanelComponent self)
        {
        }

        [EntitySystem]
        private static void YIUIBind(this ShopPanelComponent self)
        {
            self.UIBind();
        }

        private static void UIBind(this ShopPanelComponent self)
        {
            self.u_UIBase = self.GetParent<YIUIChild>();
            self.u_UIWindow = self.UIBase.GetComponent<YIUIWindowComponent>();
            self.u_UIPanel = self.UIBase.GetComponent<YIUIPanelComponent>();
            self.UIWindow.WindowOption = EWindowOption.HaveIOpenAllowOpen;
            self.UIPanel.Layer = EPanelLayer.Panel;
            self.UIPanel.PanelOption = EPanelOption.TimeCache;
            self.UIPanel.StackOption = EPanelStackOption.VisibleTween;
            self.UIPanel.Priority = 0;
            self.UIPanel.CachePanelTime = 10;

            self.u_DataCurrentSelect = self.UIBase.DataTable.FindDataValue<YIUIFramework.UIDataValueInt>("u_DataCurrentSelect");
            self.u_UIYIUIBack_Home = self.UIBase.CDETable.FindUIOwner<ET.Client.YIUIBack_HomeComponent>("YIUIBack_Home");
            self.u_UIYIUIClose_Black = self.UIBase.CDETable.FindUIOwner<ET.Client.YIUICloseCommonComponent>("YIUIClose_Black");

        }
    }
}
