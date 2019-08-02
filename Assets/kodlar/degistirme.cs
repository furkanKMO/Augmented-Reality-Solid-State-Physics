using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class degistirme : MonoBehaviour
{
    public Text a;
    private string deg;
    private int sayac = 1,bsay=1,ssay=1;
    public GameObject f1, f2,b1,b2,s1,s2,r1,r2;
    public GameObject sa1, sa2, ba1, ba2, fa1, fa2;
    public AnimationClip sc1,sc1t,fcc1,fcc1t,bcc1,bcc1t;
    public Animation sca1,sca1t,bcca1,bcca1t,fcca1,fcca1t;
    
    public void degis()
    {
        deg = a.text;
        if (deg=="fcc"&&sayac==0)
        {
            f1.gameObject.SetActive(true);
            f2.gameObject.SetActive(false);
            r1.gameObject.SetActive(true);
            r2.gameObject.SetActive(false);
            sayac = 1;
        }
        else if (deg=="fcc"&&sayac==1)
        {
            f1.gameObject.SetActive(false);
            f2.gameObject.SetActive(true);
            r1.gameObject.SetActive(false);
            r2.gameObject.SetActive(true);
            sayac = 0;
        }
        //-------------------
        if (deg == "bcc" && bsay == 0)
        {
            b1.gameObject.SetActive(true);
            b2.gameObject.SetActive(false);
            r1.gameObject.SetActive(true);
            r2.gameObject.SetActive(false);
            bsay = 1;
        }
        else if (deg == "bcc" && bsay == 1)
        {
            b1.gameObject.SetActive(false);
            b2.gameObject.SetActive(true);
            r1.gameObject.SetActive(false);
            r2.gameObject.SetActive(true);
            bsay = 0;
        }
        //----------------
        if (deg == "sc" && ssay == 0)
        {
            sca1t.clip = sc1t;
            s2.gameObject.SetActive(false);
            sa2.gameObject.SetActive(true);
            sca1t.Play();


            Invoke("stop1(sca1t)", 3f);

            //s1.gameObject.SetActive(true);
            //    sa2.gameObject.SetActive(false);
            //    sca1t.gameObject.SetActive(false);
            //    r1.gameObject.SetActive(true);
            //    r2.gameObject.SetActive(false);

           
            ssay = 1;
        }
        else if (deg == "sc" && ssay == 1)
        {
            sca1.clip = sc1;
            s1.gameObject.SetActive(false);
            sa1.gameObject.SetActive(true);
            sca1.Play();


            Invoke("stop1(sca1)", 3f);
            //s2.gameObject.SetActive(true);
            //    sa1.gameObject.SetActive(false);
            //    sca1.gameObject.SetActive(false);
            //    r1.gameObject.SetActive(false);
            //    r2.gameObject.SetActive(true);
           

            ssay = 0;
        }
    }
    IEnumerator waiter()
    {

        yield return new WaitForSecondsRealtime(3f);
        


    }
    public void stop1(Animation at) { at.Stop(); }
}
