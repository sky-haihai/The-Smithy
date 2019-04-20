using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheSmithy.Data {

    [CreateAssetMenu(menuName ="MyArmor")]
    public class MyArmor : MyItem {

        [Range(0, 100)] [Tooltip("基础防御")] public int basicDefense = 0;

        [Range(0, 2000)] [Tooltip("价格")] public int price = 0;

        [Tooltip("套装奖励类型")] public SetBonusTypes bonusType;
        [Range(0, 30)] [Tooltip("套装奖励数值")] public float SetBonus = 0;
    }
}