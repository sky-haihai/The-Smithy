using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using TheSmithy.Data;

namespace TheSmithy.Editor {

    [CustomEditor(typeof(MyItem))]
    public class MyItemEditor : UnityEditor.Editor {

        public override void OnInspectorGUI() {
            base.OnInspectorGUI();
        }
    }
}
