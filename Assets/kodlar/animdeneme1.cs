using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animdeneme1 : MonoBehaviour
{
    public Text a;
    private string deg;
    private int bsay = 1, ssay = 1,fsay=1,dol=0;
    public GameObject f1, f2, b1, b2, s1, s2, r1, r2;
    public GameObject sa1, sa2, ba1, ba2, fa1, fa2;
    public GameObject panel, dosc, dobc, dofc;
    public AnimationClip sc1, sc1t, fcc1, fcc1t, bcc1, bcc1t;
    public Animation sca1, sca1t, bcca1, bcca1t, fcca1, fcca1t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (deg == "fcc" && fsay == 0)
        {
            deg = "";
            f1.gameObject.SetActive(false);
            f2.gameObject.SetActive(false);
            fcca1t.clip = bcc1t;
            f1.gameObject.SetActive(false);
            f2.gameObject.SetActive(false);
            fa2.gameObject.SetActive(true);

            fcca1t.Play();
            f1.gameObject.SetActive(false);
            f2.gameObject.SetActive(false);
            StartCoroutine(fcc1twait());
        }
        if (deg == "fcc" && fsay == 1)
        {
            deg = "";
            f1.gameObject.SetActive(false);
            f2.gameObject.SetActive(false);
            fcca1.clip = bcc1;
            f1.gameObject.SetActive(false);
            f2.gameObject.SetActive(false);
            fa1.gameObject.SetActive(true);
            fcca1.Play();
            f1.gameObject.SetActive(false);
            f2.gameObject.SetActive(false);
            StartCoroutine(fcc1wait());
        }
        //-------------------
        if (deg == "bcc" && bsay == 0)
        {
            deg = "";
            b1.gameObject.SetActive(false);
            b2.gameObject.SetActive(false);
            bcca1t.clip = bcc1t;
            b1.gameObject.SetActive(false);
            b2.gameObject.SetActive(false);
            ba2.gameObject.SetActive(true);
            ba1.gameObject.SetActive(false);
            bcca1t.Play();
            b1.gameObject.SetActive(false);
            b2.gameObject.SetActive(false);
            StartCoroutine(bcc1twait());
        }
        if (deg == "bcc" && bsay == 1)
        {
            deg = "";
            b1.gameObject.SetActive(false);
            b2.gameObject.SetActive(false);
            bcca1.clip = bcc1;
            b1.gameObject.SetActive(false);
            b2.gameObject.SetActive(false);
            ba1.gameObject.SetActive(true);
            ba2.gameObject.SetActive(false);
            bcca1.Play();
            b1.gameObject.SetActive(false);
            b2.gameObject.SetActive(false);
            StartCoroutine(bcc1wait());
        }
        //----------------
        if (deg == "sc" && ssay == 0)
        {
            
            deg = "";
            s2.SetActive(false);
            s1.SetActive(false);
            sca1t.clip = sc1t;
            sa2.gameObject.SetActive(true);
            sca1t.Play();
            StartCoroutine(sc1twait());
        }
         if (deg == "sc" && ssay == 1)
        {
            deg = "";
            s2.SetActive(false);
            s1.SetActive(false);
            sca1.clip = sc1;
            sa1.gameObject.SetActive(true);
            sca1.Play();
            StartCoroutine(sc1wait());   
        }
    }
    public void stop1(Animation at) { at.Stop(); }
    public void degistirme1() {
        
        deg = a.text;
        
    }
    public void doluluk() { deg = a.text; dol = 1; }
    IEnumerator sc1wait()
    {
        s2.SetActive(false);
        s1.SetActive(false);
        yield return new WaitForSecondsRealtime(sca1.clip.length);
        s2.SetActive(false);
        s1.SetActive(false);
        sca1.Stop();
        s2.SetActive(false);
        s1.SetActive(false);
        sa1.gameObject.SetActive(false);
        sca1.gameObject.SetActive(false);
        s1.gameObject.SetActive(false);
        s2.gameObject.SetActive(true);
        r1.gameObject.SetActive(false);
        r2.gameObject.SetActive(true);
        if (dol == 1)
        {
            dosc.SetActive(true);
            panel.SetActive(true);
        }
        deg = "";
        ssay = 0;
    }
    IEnumerator sc1twait()
    {
        if (dol == 1)
        {
            dosc.SetActive(false);
            panel.SetActive(false);
        }
        s2.SetActive(false);
        s1.SetActive(false);
        yield return new WaitForSecondsRealtime(sca1t.clip.length);
        s2.SetActive(false);
        s1.SetActive(false);
        sca1t.Stop();
        s2.SetActive(false);
        s1.SetActive(false);
        sa2.gameObject.SetActive(false);
        sca1t.gameObject.SetActive(false);
        s2.gameObject.SetActive(false);
        s1.gameObject.SetActive(true);
        r1.gameObject.SetActive(true);
        r2.gameObject.SetActive(false);
        deg = "";
        ssay = 1;     
    }
    IEnumerator bcc1wait()
    {
        b1.gameObject.SetActive(false);
        b2.gameObject.SetActive(false);
        yield return new WaitForSecondsRealtime(bcca1.clip.length);
        b1.gameObject.SetActive(false);
        b2.gameObject.SetActive(false);
        bcca1.Stop();

        ba1.gameObject.SetActive(false);
        ba2.gameObject.SetActive(false);
        bcca1.gameObject.SetActive(false);
        b2.gameObject.SetActive(true);
        b1.gameObject.SetActive(false);
        r1.gameObject.SetActive(false);
        r2.gameObject.SetActive(true);
        if (dol == 1)
        {
            dobc.SetActive(true);
            panel.SetActive(true);
        }
        deg = "";
        bsay = 0;
        

    }
    IEnumerator bcc1twait()
    {
        if (dol == 1)
        {
            dobc.SetActive(false);
            panel.SetActive(false);
        }
        b1.gameObject.SetActive(false);
        b2.gameObject.SetActive(false);
        yield return new WaitForSecondsRealtime(bcca1t.clip.length);
        b1.gameObject.SetActive(false);
        b2.gameObject.SetActive(false);
        bcca1t.Stop();

        ba1.gameObject.SetActive(false);
        ba2.gameObject.SetActive(false);
        bcca1t.gameObject.SetActive(false);
        b2.gameObject.SetActive(false);
        b1.gameObject.SetActive(true);
        r1.gameObject.SetActive(true);
        r2.gameObject.SetActive(false);
        deg = "";
        bsay = 1;
       
    }
    IEnumerator fcc1wait()
    {
        f1.gameObject.SetActive(false);
        f2.gameObject.SetActive(false);
        yield return new WaitForSecondsRealtime(fcca1.clip.length);
        f1.gameObject.SetActive(false);
        f2.gameObject.SetActive(false);
        fcca1.Stop();
        f1.gameObject.SetActive(false);
        f2.gameObject.SetActive(false);
        fa1.gameObject.SetActive(false);
        fcca1.gameObject.SetActive(false);
        f2.gameObject.SetActive(true);
        f1.gameObject.SetActive(false);
        r1.gameObject.SetActive(false);
        r2.gameObject.SetActive(true);
        if (dol == 1)
        {
            dofc.SetActive(true);
            panel.SetActive(true);
        }
        deg = "";
        fsay = 0;
       

    }
    IEnumerator fcc1twait()
    {
        if (dol == 1)
        {
            dofc.SetActive(false);
            panel.SetActive(false);
        }
        f1.gameObject.SetActive(false);
        f2.gameObject.SetActive(false);

        yield return new WaitForSecondsRealtime(fcca1t.clip.length);
        f1.gameObject.SetActive(false);
        f2.gameObject.SetActive(false);
        fcca1t.Stop();
        f1.gameObject.SetActive(false);
        f2.gameObject.SetActive(false);
        fa2.gameObject.SetActive(false);
        fcca1t.gameObject.SetActive(false);
        f2.gameObject.SetActive(false);
        f1.gameObject.SetActive(true);
        r1.gameObject.SetActive(true);
        r2.gameObject.SetActive(false);
       
        deg = "";
        fsay = 1;

       
    }
}
