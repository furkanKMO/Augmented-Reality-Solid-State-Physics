using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class formülkod : MonoBehaviour
{
    int sayac = 0; string s = "0";
    // 0=gizli
    // 1=açık
    public GameObject panel,s1,b1,f1;
    public Text  sec,yazi;
   // public GameObject uyari;
    

    public void showhidepanel()
    {//(sec.text=="sc"|| sec.text == "bcc" || sec.text == "fcc" )
        Debug.Log(sec.text);
        sayac = 0;
        if (ApplicationData.PlayerName == "sc")
        {
            yazi.text = "6 adet komşu yeşil renkte belirtilmiştir.";
        }
        if (ApplicationData.PlayerName == "bcc")
        {
            yazi.text = "8 adet komşu yeşil renkte belirtilmiştir.";
        }
        if (ApplicationData.PlayerName == "fcc")
        {
            yazi.text = "12 adet komşu yeşil renkte belirtilmiştir.";
        }
        if (panel.activeSelf == false && sayac == 0)
        {
            panel.gameObject.SetActive(true);
            
            sayac = 1;
        }
        if (panel.activeSelf == true && sayac == 0)
        {
            panel.gameObject.SetActive(false);
            sayac = 1;

        }

        //if (sec.text == "" || sec.text == "Model Seçin." || sec.text == null)
        //{
        //    panel.gameObject.SetActive(false);
        //    uyari.gameObject.SetActive(true);

        //}


    }
}
