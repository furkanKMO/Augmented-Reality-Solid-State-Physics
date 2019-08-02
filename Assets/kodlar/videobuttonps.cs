using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class videobuttonps : MonoBehaviour
{
    public Text tak;
    public GameObject b1, b2;
    private int a = 0;
    private string s = "0";
    
    public void play() {

        if (a == 0)
        {
            b1.gameObject.SetActive(false);
            b2.gameObject.SetActive(true);
            a = 1;

        }
        else if (a == 1)
        {
            b1.gameObject.SetActive(true);
            b2.gameObject.SetActive(false);
            a = 0;
        }
    }
}
