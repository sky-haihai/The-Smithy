using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TheSmithy.Data {

    [CreateAssetMenu(menuName = "MyCharacter")]
    public class MyCharacter : ScriptableObject {

        public string Name;
        public int index;

        public CharaType type;

        public float attack;
        public float defense;
        public float health;

        public string description;
    }
}
