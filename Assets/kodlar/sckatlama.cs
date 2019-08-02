using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sckatlama : MonoBehaviour
{
    public GameObject scana,s1, s2, s3,bccana,b1,b2,b3,fccana,f1,f2,f3,uyari;
    public AnimationClip scac1, scac2, scac3;
    public Animation sca1, sca2, sca3,bca1,bca2,bca3,fca1,fca2,fca3;
    int ssay = 0,rsay=0;
    public Text a;
    private string t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (t=="sc"&&ssay==0&&rsay<2)
        {
            scana.SetActive(false);
            s1.SetActive(true);
            s2.SetActive(false);
            s3.SetActive(false);
           // sca1.clip = scac1;
            sca1["Take 001"].speed = 2f;
            rsay = 2;
            sca1.Play();
           StartCoroutine( wait1());
            
           

        }
        if (t == "sc" && ssay == 1 && rsay < 2)
        {
            s1.SetActive(false);
            s2.SetActive(true);
            s3.SetActive(false);
            sca2.clip = scac2;
            sca2["Take 001"].speed = 2f;
            rsay = 2;
            sca2.Play();
            StartCoroutine(wait2());
            
            

        }
        if (t == "sc" && ssay == 2 && rsay < 2)
        {
            s1.SetActive(false);
            s2.SetActive(false);
            s3.SetActive(true);
            sca3.clip = scac3;
            sca3["Take 001"].speed = 2f;
            rsay = 2;
            sca3.Play();
            StartCoroutine(wait3());
            
            

        }
        if (t == "bcc" && ssay == 0 && rsay < 2)
        {
            bccana.SetActive(false);
            b1.SetActive(true);
            b2.SetActive(false);
            b3.SetActive(false);
            //sca1.clip = scac1;
            bca1["Take 001"].speed = 2f;
            rsay = 2;
            bca1.Play();
            StartCoroutine(wait1());



        }
        if (t == "bcc" && ssay == 1 && rsay < 2)
        {
            b1.SetActive(false);
            b2.SetActive(true);
            b3.SetActive(false);
            //sca2.clip = scac2;
            bca2["Take 001"].speed = 2f;
            rsay = 2;
            bca2.Play();
            StartCoroutine(wait2());



        }
        if (t == "bcc" && ssay == 2 && rsay < 2)
        {
            b1.SetActive(false);
            b2.SetActive(false);
            b3.SetActive(true);
            //sca3.clip = scac3;
            bca3["Take 001"].speed = 2f;
            rsay = 2;
            bca3.Play();
            StartCoroutine(wait3());



        }
        if (t == "fcc" && ssay == 0 && rsay < 2)
        {
            fccana.SetActive(false);
            f1.SetActive(true);
            f2.SetActive(false);
            f3.SetActive(false);
            //sca1.clip = scac1;
            fca1["Take 001"].speed = 1f;
            rsay = 2;
            fca1.Play();
            StartCoroutine(wait1());



        }
        if (t == "fcc" && ssay == 1 && rsay < 2)
        {
            f1.SetActive(false);
            f2.SetActive(true);
            f3.SetActive(false);
            //sca2.clip = scac2;
            fca2["Take 001"].speed = 2f;
            rsay = 2;
            fca2.Play();
            StartCoroutine(wait2());



        }
        if (t == "fcc" && ssay == 2 && rsay < 2)
        {
            f1.SetActive(false);
            f2.SetActive(false);
            f3.SetActive(true);
            //sca3.clip = scac3;
            fca3["Take 001"].speed = 2f;
            fca3.Play();
            rsay = 2;
            StartCoroutine(wait3());



        }
    }
    public void tus() {
        t = a.text;
        if (t == "sc" || t == "bcc" || t == "fcc")
        {
            s1.SetActive(false);
            s2.SetActive(false);
            s3.SetActive(false);
            scana.SetActive(true);
            b1.SetActive(false);
            b2.SetActive(false);
            b3.SetActive(false);
            bccana.SetActive(true);
            f1.SetActive(false);
            f2.SetActive(false);
            f3.SetActive(false);
            fccana.SetActive(true);
            ssay = 0;
            rsay = 1;
        }
        else
        {
            
            uyari.gameObject.SetActive(true);
        }
    }
    IEnumerator wait1()
    {
        yield return new WaitForSecondsRealtime(fca1.clip.length);
        ssay = 1;
        rsay = 1;
        Debug.Log(ssay.ToString());
    }
    IEnumerator wait2()
    {
        yield return new WaitForSecondsRealtime(fca2.clip.length);
        ssay = 2;
        rsay = 1;
        Debug.Log(ssay.ToString());
    }
    IEnumerator wait3()
    {
        yield return new WaitForSecondsRealtime(fca3.clip.length);
        ssay = 3;
        rsay = 1;
        Debug.Log(ssay.ToString());
    }
}
