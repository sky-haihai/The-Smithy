using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheSmithy.Data;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

namespace TheSmithy {

    public class MyCharacter {
        public int hp;
    }

    public class MyMonster {
        public int hp;
    }

    //[DisallowMultipleComponent]
    public class GameController : MonoBehaviour {

        //turn base events
        UnityEvent m_Next;
        UnityEvent m_GameOver;
        UnityEvent m_GameWin;

        public static GameController instance;

        [HideInInspector]
        public PlayerData data;

        public MyStage stagedata;

        public Transform[] charaSpawnSpot;

        public Transform[][] monsterSpawnSpots;
        
        int m_roomIndex = 0;
        private Transform[] currentCharaSpots;
        private Transform[] currentMonsterSpots;

        /// <summary>
        /// hp为0清除
        /// </summary>
        List<MyCharacter> currentCharacters;
        List<GameObject> currentMonsters; //类型修改

        private void Start() {

            if (instance == null) {
                instance = this;
            } else {
                Destroy(gameObject);
            }

            if (!(SLBehavior.Load() == null)) {
                data = SLBehavior.Load();
            } else {
                Debug.LogError("找不到存档");
            }

            DontDestroyOnLoad(gameObject);
        }

        private void Update() {
            DetectEvents();

            if (Input.GetKeyDown(KeyCode.Space)) {
                if (m_roomIndex == 0) {
                    SpawnChara();
                }
                SpawnMonster(m_roomIndex);
                m_roomIndex += 1;
            }
        }

        void SpawnChara() {
            for (int i = 0; i < charaSpawnSpot.Length; i++) {
                GameObject chara = new GameObject("character " + i.ToString());
                chara.transform.SetParent(charaSpawnSpot[i], false);
                chara.AddComponent<EmptyIndicator>();
            }
        }

        void SpawnMonster(int index) {

        }

        void SwitchScene(string name) {
            AsyncOperation operation = SceneManager.LoadSceneAsync(name, LoadSceneMode.Single);
        }

        void DetectEvents() {
            if (currentCharacters.Count == 0) {
                m_GameOver.Invoke();
            }

            if (true) {

            }

            foreach(var character in currentCharacters) {
                if (character.hp <= 0) {
                    character.hp = 0;
                    currentCharacters.Remove(character);
                }
            }
        }
    }
}
