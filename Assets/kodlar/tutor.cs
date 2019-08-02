using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutor : MonoBehaviour
{
    public GameObject tutorial;
    private int sayac = 1;
    // Start is called before the first frame update
    public void ackapa() {
        sayac = 0;
        if (tutorial.activeSelf == false && sayac == 0)
        {
            tutorial.gameObject.SetActive(true);
            sayac = 1;

        }
        if (tutorial.activeSelf == true&&sayac==0 )
        {
            tutorial.gameObject.SetActive(false);
            sayac = 1;

        }
      
    }
}
