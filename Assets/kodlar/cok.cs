using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cok : MonoBehaviour
{
    public GameObject uyari;
    public GameObject s1, s2, b1, b2, f1, f2;
    public GameObject sa1, sa2, sa3, sa4, sa5, sa6, ba1, ba2, ba3, ba4, ba5, ba6, fa1, fa2, fa3, fa4, fa5, fa6;
    public GameObject sb1, sb2, sb3, sb4, sb5, sb6, bb1, bb2, bb3, bb4, bb5, bb6, fb1, fb2, fb3, fb4, fb5, fb6;
    public GameObject r1, r2;
    public Text deger;  
    private string deg,bas;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (s1.gameObject.activeInHierarchy == true && deg == "sc" )
        {
            sa1.gameObject.SetActive(true);
            sa2.gameObject.SetActive(true);
            sa3.gameObject.SetActive(true);
            sa4.gameObject.SetActive(true);
            sa5.gameObject.SetActive(true);
            sa6.gameObject.SetActive(true);
            sb1.gameObject.SetActive(false);
            sb2.gameObject.SetActive(false);
            sb3.gameObject.SetActive(false);
            sb4.gameObject.SetActive(false);
            sb5.gameObject.SetActive(false);
            sb6.gameObject.SetActive(false);



        }
        if (s2.gameObject.activeInHierarchy == true && deg == "sc" )
        {
            sb1.gameObject.SetActive(true);
            sb2.gameObject.SetActive(true);
            sb3.gameObject.SetActive(true);
            sb4.gameObject.SetActive(true);
            sb5.gameObject.SetActive(true);
            sb6.gameObject.SetActive(true);
            sa1.gameObject.SetActive(false);
            sa2.gameObject.SetActive(false);
            sa3.gameObject.SetActive(false);
            sa4.gameObject.SetActive(false);
            sa5.gameObject.SetActive(false);
            sa6.gameObject.SetActive(false);

        }
        if (b1.gameObject.activeInHierarchy == true && deg == "bcc")
        {
            ba1.gameObject.SetActive(true);
            ba2.gameObject.SetActive(true);
            ba3.gameObject.SetActive(true);
            ba4.gameObject.SetActive(true);
            ba5.gameObject.SetActive(true);
            ba6.gameObject.SetActive(true);
            bb1.gameObject.SetActive(false);
            bb2.gameObject.SetActive(false);
            bb3.gameObject.SetActive(false);
            bb4.gameObject.SetActive(false);
            bb5.gameObject.SetActive(false);
            bb6.gameObject.SetActive(false);

        }
        if (b2.gameObject.activeInHierarchy == true && deg == "bcc")
        {
            bb1.gameObject.SetActive(true);
            bb2.gameObject.SetActive(true);
            bb3.gameObject.SetActive(true);
            bb4.gameObject.SetActive(true);
            bb5.gameObject.SetActive(true);
            bb6.gameObject.SetActive(true);
            ba1.gameObject.SetActive(false);
            ba2.gameObject.SetActive(false);
            ba3.gameObject.SetActive(false);
            ba4.gameObject.SetActive(false);
            ba5.gameObject.SetActive(false);
            ba6.gameObject.SetActive(false);
        }
        if (f1.gameObject.activeInHierarchy == true && deg == "fcc")
        {
            fa1.gameObject.SetActive(true);
            fa2.gameObject.SetActive(true);
            fa3.gameObject.SetActive(true);
            fa4.gameObject.SetActive(true);
            fa5.gameObject.SetActive(true);
            fa6.gameObject.SetActive(true);
            fb1.gameObject.SetActive(false);
            fb2.gameObject.SetActive(false);
            fb3.gameObject.SetActive(false);
            fb4.gameObject.SetActive(false);
            fb5.gameObject.SetActive(false);
            fb6.gameObject.SetActive(false);
        }
        if (f2.gameObject.activeInHierarchy == true && deg == "fcc" )
        {
            fb1.gameObject.SetActive(true);
            fb2.gameObject.SetActive(true);
            fb3.gameObject.SetActive(true);
            fb4.gameObject.SetActive(true);
            fb5.gameObject.SetActive(true);
            fb6.gameObject.SetActive(true);
            fa1.gameObject.SetActive(false);
            fa2.gameObject.SetActive(false);
            fa3.gameObject.SetActive(false);
            fa4.gameObject.SetActive(false);
            fa5.gameObject.SetActive(false);
            fa6.gameObject.SetActive(false);

        }

    }
    public void tuslatek()
    {
        Debug.Log("a");
        deg = "";
        Debug.Log("b");
        sa1.gameObject.SetActive(false);
        sa2.gameObject.SetActive(false);
        sa3.gameObject.SetActive(false);
        sa4.gameObject.SetActive(false);
        sa5.gameObject.SetActive(false);
        sa6.gameObject.SetActive(false);
        sb1.gameObject.SetActive(false);
        sb2.gameObject.SetActive(false);
        sb3.gameObject.SetActive(false);
        sb4.gameObject.SetActive(false);
        sb5.gameObject.SetActive(false);
        sb6.gameObject.SetActive(false);
        // --------------
        ba1.gameObject.SetActive(false);
        ba2.gameObject.SetActive(false);
        ba3.gameObject.SetActive(false);
        ba4.gameObject.SetActive(false);
        ba5.gameObject.SetActive(false);
        ba6.gameObject.SetActive(false);
        bb1.gameObject.SetActive(false);
        bb2.gameObject.SetActive(false);
        bb3.gameObject.SetActive(false);
        bb4.gameObject.SetActive(false);
        bb5.gameObject.SetActive(false);
        bb6.gameObject.SetActive(false);
        //---------------
        fa1.gameObject.SetActive(false);
        fa2.gameObject.SetActive(false);
        fa3.gameObject.SetActive(false);
        fa4.gameObject.SetActive(false);
        fa5.gameObject.SetActive(false);
        fa6.gameObject.SetActive(false);
        fb1.gameObject.SetActive(false);
        fb2.gameObject.SetActive(false);
        fb3.gameObject.SetActive(false);
        fb4.gameObject.SetActive(false);
        fb5.gameObject.SetActive(false);
        fb6.gameObject.SetActive(false);
        //-----------------
        Debug.Log("c");
        r2.gameObject.SetActive(false);
        Debug.Log("d");
    }
    public void tuslacok() {

      
        deg = deger.text;
        if (deg == "sc" || deg == "bcc" || deg == "fcc")
       {
            r2.gameObject.SetActive(true);
            
        }
       else {
            uyari.gameObject.SetActive(true);
        }


    }
    
}
