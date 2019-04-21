using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TheSmithy.Data;

public class container : MonoBehaviour
{
    public MyItem Contains;
    public void Set_image()
    {
        if (Contains == null)
            GetComponent<Image>().sprite = null;
        else
            GetComponent<Image>().sprite = Contains.icon;
    }
    private void Start()
    {
        Set_image();
    }
}
