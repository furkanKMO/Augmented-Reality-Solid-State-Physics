using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hide : MonoBehaviour
{
    int sayac = 0;string s="0";
    // 0=gizli
    // 1=açık
    public GameObject panel;
    public Text a,sec;
    public GameObject uyari;
    
    public void showhidepanel()
    {//(sec.text=="sc"|| sec.text == "bcc" || sec.text == "fcc" )
        Debug.Log(sec.text);
        sayac = 0;
        if (panel.activeSelf==false&&sayac==0)
        {
            panel.gameObject.SetActive(true);
            a.text = s;
            sayac = 1;
        }
        if (panel.activeSelf == true&&sayac==0)
        {
            panel.gameObject.SetActive(false);
            sayac = 1;

        }

        if (sec.text == "" || sec.text == "Model Seçin." || sec.text==null)
        {
            panel.gameObject.SetActive(false);
            uyari.gameObject.SetActive(true);
           
        }
       

    }
}
