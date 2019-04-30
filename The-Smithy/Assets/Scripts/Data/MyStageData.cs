using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheSmithy {

    [System.Serializable]
    public class MonsterSet {
        public GameObject[] monsters;
    }

    [CreateAssetMenu(menuName = "MyStage")]
    public class MyStageData : ScriptableObject {

        /// <summary>
        /// 房间的个数
        /// </summary>
        public int roomSize;

        public List<MonsterSet> monsterSets;

    }
}