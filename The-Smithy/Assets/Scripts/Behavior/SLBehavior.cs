using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using TheSmithy.Data;

namespace TheSmithy {
    public class SLBehavior : MonoBehaviour {

        public static void Save(PlayerData data) {
            //convert file to binary file
            string path = Application.persistentDataPath + "save.smithy";

            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Create);

            bf.Serialize(stream, data);
            stream.Close();
            stream.Dispose();
        }

        public static PlayerData Load() {
            string path = Application.persistentDataPath + "save.smithy";
            if (File.Exists(path)) {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);

                PlayerData file = bf.Deserialize(stream) as PlayerData;
                stream.Close();

                return file;
            }
            return null;
        }
    }
}
