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
    public partial class ShopChestViewComponent : Entity
    {
        public List<ShopItemData> ShopItemDataList;
        public EntityRef<YIUILoopScrollChild> u_LoopScrollChild;
        public YIUILoopScrollChild LoopScrollChild => u_LoopScrollChild;
    }
}
