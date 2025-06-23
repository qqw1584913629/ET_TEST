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
    public partial class ShopPanelComponent : Entity, IYIUIOpen<EShopPanelViewEnum>
    {

    }
    [EnableClass]
    public class ShopItemData
    {
        public string Name;
        public int Price;
        public bool IsAd;
        public bool IsPopular;
        public int Icon;
    }
}
