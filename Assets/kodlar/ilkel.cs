using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ilkel : MonoBehaviour
{
    public GameObject sc, bc, fc;

    public int sayac; public void aciklama1()
    {
        sayac = 0;
        if ((sc.activeSelf == false || bc.activeSelf == false || fc.activeSelf == false) && sayac == 0)
        {
            sc.SetActive(true);
            bc.SetActive(true);
            fc.SetActive(true);
            sayac = 1;
        }
        if ((sc.activeSelf == true || bc.activeSelf == true || fc.activeSelf == true) && sayac == 0)
        {
            sc.SetActive(false);
            bc.SetActive(false);
            fc.SetActive(false);
            sayac = 1;
        }

    }



}
