using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSwitch : MonoBehaviour
{
    public Dropdown ColorDrop;
    public GameObject Player;

    public void colorSwitch()
    {
        switch (ColorDrop.value)
        {
            case 0:
                Player.GetComponent<Renderer>().material.color = Color.white;
                break;
            case 1:
                Player.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 2:
                Player.GetComponent<Renderer>().material.color = Color.red;
                break;
        }
    }
}
