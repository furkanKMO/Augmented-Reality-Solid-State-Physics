using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acilis : MonoBehaviour
{
    public static bool yeniacik = false;
    public GameObject uyari;
    // Start is called before the first frame update
    void Start()
    {
        if (yeniacik==false)
        {
            uyari.gameObject.SetActive(true);
            
            acilis.yeniacik = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
