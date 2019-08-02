using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alar : MonoBehaviour
{
    public GameObject asc1, asc2, asc3;
    //, abcc1,abcc2,abcc3, afcc1,afcc2,afcc3;
    int sayac;
    public Transform target;
    

    void Update()
    {
        // Rotate the camera every frame so it keeps looking at the target
        //asc1.transform.LookAt(target);
        //abcc1.transform.LookAt(target);
        //afcc1.transform.LookAt(target);
        //asc2.transform.LookAt(target);
        //abcc2.transform.LookAt(target);
        //afcc2.transform.LookAt(target);
       // asc3.transform.LookAt(target);
        //abcc3.transform.LookAt(target);
        //afcc3.transform.LookAt(target);
    }
    public void atus() {
        sayac = 0;
        if (asc1.activeSelf==false&&sayac==0)
        {
            asc1.SetActive(true);
            //abcc1.SetActive(true);
            //afcc1.SetActive(true);
            asc2.SetActive(true);
            //abcc2.SetActive(true);
            //afcc2.SetActive(true);
            asc3.SetActive(true);
            //abcc3.SetActive(true);
            //afcc3.SetActive(true);
            sayac = 1;
        }
        if (asc1.activeSelf == true && sayac == 0)
        {
            asc1.SetActive(false);
            //abcc1.SetActive(false);
            //afcc1.SetActive(false);
            asc2.SetActive(false);
            //abcc2.SetActive(false);
            //afcc2.SetActive(false);
            asc3.SetActive(false);
            //abcc3.SetActive(false);
            //afcc3.SetActive(false);

            sayac = 1;
        }

    }
}
