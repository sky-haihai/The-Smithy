using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheSmithy.Data {
    [CreateAssetMenu(fileName = "new item")]
    public class MyMaterial : ScriptableObject {

        [Tooltip("图标")] public Sprite icon;

        [Tooltip("名称")] public string itemName = "item name here";

        [Range(0, 6)] [Tooltip("稀有度")] public int rarity = 0;

        [Tooltip("描述")] public string description = "item description here";

        [Tooltip("是否可以购买")] public bool isPurchasable;

        [Range(0, 1000)] public int price = 0;

    }
}
