using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TheSmithy.Data {
    public class MyItem : ScriptableObject {

        [Tooltip("名称")] public string itemName = "";
        [Range(1, 36)] [Tooltip("编号")] public int index = 1;
        [Range(1, 6)] [Tooltip("稀有度")] public int rarity = 1;

        [Tooltip("图标")] public Sprite icon;
        [Tooltip("描述")] public string description = "item description here";
    }
}
