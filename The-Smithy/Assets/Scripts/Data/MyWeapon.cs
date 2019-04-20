using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheSmithy.Data {

    [CreateAssetMenu(menuName = "MyWeapon")]
    public class MyWeapon : MyItem {

        [Tooltip("武器类型")]public WeaponTypes weaponTypes;

        [Range(0, 100)] [Tooltip("基础攻击")] public int basicAttack = 0;

        [Range(0, 2000)] [Tooltip("价格")] public int price = 0;
    }
}
