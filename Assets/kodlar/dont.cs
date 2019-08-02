using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class dont : MonoBehaviour
{
    public Text dontdestroytext1, a;
    void Start()
    {
        DontDestroyOnLoad(dontdestroytext1);
    }

    // Update is called once per frame
    void Update()
    {
        dontdestroytext1.text = a.text;
        ApplicationData.PlayerName = dontdestroytext1.text;
       // DontDestroyOnLoad(dontdestroytext1);
    }
}
public static class ApplicationData
{
    public static string PlayerName;
}
