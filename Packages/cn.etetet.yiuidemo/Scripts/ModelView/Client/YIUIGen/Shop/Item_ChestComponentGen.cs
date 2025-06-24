using System;
using UnityEngine;
using YIUIFramework;
using System.Collections.Generic;

namespace ET.Client
{

    /// <summary>
    /// 由YIUI工具自动创建 请勿修改
    /// </summary>
    [YIUI(EUICodeType.Common)]
    [ComponentOf(typeof(YIUIChild))]
    public partial class Item_ChestComponent : Entity, IDestroy, IAwake, IYIUIBind, IYIUIInitialize
    {
        public const string PkgName = "Shop";
        public const string ResName = "Item_Chest";

        public EntityRef<YIUIChild> u_UIBase;
        public YIUIChild UIBase => u_UIBase;
        public YIUIFramework.UIDataValueString u_DataItemName;
        public YIUIFramework.UIDataValueString u_DataIcon;
        public YIUIFramework.UIDataValueBool u_DataIsPopular;
        public YIUIFramework.UIDataValueBool u_DataIsSelect;
        public YIUIFramework.UIDataValueBool u_DataIsAd;
        public YIUIFramework.UIDataValueInt u_DataPrice;

    }
}