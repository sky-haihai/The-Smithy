using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="new item")]
public class MyItem : ScriptableObject {

    public Sprite icon;

    public string itemName = "item name here";

    public string description = "item description here";

    [Tooltip("price per item")]
    public int price = 0;

}
