using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheSmithy.Data;

public class GameController : MonoBehaviour {

    PlayerData data = new PlayerData();

    private void Start() {
        if (!(SLBehavior.Load() == null)) {
            data = SLBehavior.Load();
            Debug.Log(data.alcohol);
        }
        data.alcohol = 1;
        SLBehavior.Save(data);
    }
}
