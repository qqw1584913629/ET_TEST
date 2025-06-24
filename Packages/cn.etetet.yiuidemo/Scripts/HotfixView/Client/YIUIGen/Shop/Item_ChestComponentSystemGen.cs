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
    [EntitySystemOf(typeof(Item_ChestComponent))]
    public static partial class Item_ChestComponentSystem
    {
        [EntitySystem]
        private static void Awake(this Item_ChestComponent self)
        {
        }

        [EntitySystem]
        private static void YIUIBind(this Item_ChestComponent self)
        {
            self.UIBind();
        }

        private static void UIBind(this Item_ChestComponent self)
        {
            self.u_UIBase = self.GetParent<YIUIChild>();

            self.u_DataItemName = self.UIBase.DataTable.FindDataValue<YIUIFramework.UIDataValueString>("u_DataItemName");
            self.u_DataIcon = self.UIBase.DataTable.FindDataValue<YIUIFramework.UIDataValueString>("u_DataIcon");
            self.u_DataIsPopular = self.UIBase.DataTable.FindDataValue<YIUIFramework.UIDataValueBool>("u_DataIsPopular");
            self.u_DataIsSelect = self.UIBase.DataTable.FindDataValue<YIUIFramework.UIDataValueBool>("u_DataIsSelect");
            self.u_DataIsAd = self.UIBase.DataTable.FindDataValue<YIUIFramework.UIDataValueBool>("u_DataIsAd");
            self.u_DataPrice = self.UIBase.DataTable.FindDataValue<YIUIFramework.UIDataValueInt>("u_DataPrice");

        }
    }
}
