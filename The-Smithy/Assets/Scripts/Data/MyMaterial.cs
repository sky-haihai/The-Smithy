using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheSmithy.Data {

    [CreateAssetMenu(menuName = "MyMaterial")]
    public class MyMaterial : MyItem {

        [Range(0, 120)] [Tooltip("攻击加成")] public int attackAddition = 0;
        [Range(0, 120)] [Tooltip("防御加成")] public int defenseAddition = 0;
        [Range(0, 120)] [Tooltip("速度加成")] public int speedAddition = 0;

        [Tooltip("效果 1")] public Effects effect1;
        [Tooltip("效果 2")] public Effects effect2;

        [Tooltip("是否可以购买")] public bool isPurchasable;
        [Range(0, 1000)] public int price = 0;

    }
}
