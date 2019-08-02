using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kamerayeni : MonoBehaviour
{
    public GameObject rotator1,yazisc,yazibc,yazifc;
    private int hareket = 1, z, y,x,ic,sa,so,sayac1,sayac2=0;
    private float x1, z1,y1;
    public int sayac;
    public Text form,sec;
    private Vector3 q;
    public Camera a;
    public Transform target;

    public GameObject sc1, bc1, fc1;
    // Start is called before the first frame update
    void Start()
    {
        ic = 0; sa = 0; so = 0;
        Input.gyro.enabled = true;
        if (Input.gyro.enabled == true)
        {
            Debug.Log("gyro açık");

        }
        // a.transform.position = new Vector3(950, 2286, -860);
        a.transform.position = new Vector3(1000, 1700, -1100);
        a.transform.LookAt(target);
       
       
        y = 3250; z = -1850;
        if (ApplicationData.PlayerName == "sc")
        {
            if (sayac==0)
            {
                form.text = "Komşu Uzuluğu= a";
            }
            if (sayac == 1)
            {
                form.text = "Komşu Uzuluğu= 1,414a";
            }

            sec.text = "SC";
            sc1.SetActive(true);
            bc1.SetActive(false);
            fc1.SetActive(false);

        }
        if (ApplicationData.PlayerName == "bcc")
        {
            if (sayac == 0)
            {
                form.text = "Komşu Uzuluğu= 0,866a";
            }
            if (sayac == 1)
            {
                form.text = "Komşu Uzuluğu= a";
            }
            sec.text = "BCC";
            sc1.SetActive(false);
            bc1.SetActive(true);

            fc1.SetActive(false);
        }
        if (ApplicationData.PlayerName == "fcc")
        {
            if (sayac == 0)
            {
                form.text = "Komşu Uzuluğu= 0,707a";
            }
            if (sayac == 1)
            {
                form.text = "Komşu Uzuluğu= a";
            }
            sec.text = "FCC";
            sc1.SetActive(false);
            bc1.SetActive(false);
            fc1.SetActive(true);

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (ic == 1)
        {
            q = a.transform.position;

            if (hareket == 1)
            {
                x1 = x1 - 10;
                y1 = y1 - 10;
                if (z1<0)
                {
                    z1 = z1 + 10;
                }
                if (z1 > 0)
                {
                    z1 = z1 - 10;
                }
                transform.position = Vector3.MoveTowards(transform.position, target.position, 10);
                //a.transform.position = new Vector3(x1, y1, z1);

                if (Vector3.Distance(transform.position, target.position) < 0.001f)
                {
                    hareket = 2;
                }
            }
            if (hareket == 2)
            {
                hareket = 0;
            }
            if (hareket == 0)
            {
                a.transform.Rotate(-Input.gyro.rotationRateUnbiased.x * 2, -Input.gyro.rotationRateUnbiased.y * 2, 0);

            }

        }

        if (sa == 1)
        {
            rotator1.transform.Rotate(0, -1f, 0);
            sayac1 = sayac1+1;
            Debug.Log(sayac1.ToString());
                if (sayac1==45)
            {
                sa = 0;
                sayac1 = 0;
            }
        }
        if (so==1)
        {
            rotator1.transform.Rotate(0, 1f, 0);
            sayac1 = sayac1 + 1;
            Debug.Log(sayac1.ToString());
            if (sayac1 == 45)
            {
                so = 0;
                sayac1 = 0;
            }
        }


    }
    public void iceri() { ic = 1;
        x1 = a.transform.position.x;
        y1 = a.transform.position.y;
        z1 = a.transform.position.z;


    }
    public void disari() { ic = 2; hareket = 1; a.transform.position = new Vector3(1000, 1700, -1100); a.transform.LookAt(target); }
    public void saga()
    {
        sayac1 = 0;
        sa = 1;
        //sa += 1; if (sa==4)
        //{
        //    sa = 0;
        //}
    //    if (sa == 0)
    //    {
    //        a.transform.position = new Vector3(1000, 1700, -1100);
    //        a.transform.LookAt(target);
    //    }
    //    if (sa == 1)
    //    {
    //        a.transform.position = new Vector3(3000, 1700, 1400);
    //        a.transform.LookAt(target);
    //    }
    //    if (sa == 2)
    //    {
    //        a.transform.position = new Vector3(1000, 1700, 3700);
    //        a.transform.LookAt(target);
    //    }
    //    if (sa == 3)
    //    {
    //        a.transform.position = new Vector3(-1400, 1700, 1400);
    //        a.transform.LookAt(target);
    //    }
    }
    public void sola()
    { sayac1 =0;
        so = 1;
        //sa += 1; if (sa==-1)
        //{
        //    sa = 3;
        //}
        //if (sa == 0)
        //{
        //    a.transform.position = new Vector3(1000, 1700, -1100);
        //    a.transform.LookAt(target);
        //}
        //if (sa == 1)
        //{
        //    a.transform.position = new Vector3(3000, 1700, 1400);
        //    a.transform.LookAt(target);
        //}
        //if (sa == 2)
        //{
        //    a.transform.position = new Vector3(1000, 1700, 3700);
        //    a.transform.LookAt(target);
        //}
        //if (sa == 3)
        //{
        //    a.transform.position = new Vector3(-1400, 1700, 1400);
        //    a.transform.LookAt(target);
        //}
    }
    public void yazi() {
        sayac2 = 0;
        if ((yazisc.activeSelf == false || yazibc.activeSelf == false || yazifc.activeSelf == false)&& sayac2 ==0)
        {
         yazisc.SetActive(true);
         yazibc.SetActive(true);
         yazifc.SetActive(true);
            sayac2 = 1;
        }
        if ((yazisc.activeSelf == true|| yazibc.activeSelf == true || yazifc.activeSelf == true )&&sayac2 == 0)
        {
            yazisc.SetActive(false);
            yazibc.SetActive(false);
            yazifc.SetActive(false);
            sayac2 = 1;
        }

    }

}