using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camkontrol : MonoBehaviour
{
    private int hareket = 1, z, y;
    private Vector3 q;
    public Camera a;
    public Text aa,konum;
    public GameObject sc1, bc1, fc1,u1,u2;
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
        if (Input.gyro.enabled == true)
        {
            Debug.Log("gyro açık");
            
        }
        a.transform.position=new Vector3( 950, 2286, -860);
        y = 3250;z = -1850;
        if (ApplicationData.PlayerName == "sc")
        {
            sc1.SetActive(true);
            bc1.SetActive(false);
            fc1.SetActive(false);
            u1.SetActive(false);
            u2.SetActive(false);
        }
        if (ApplicationData.PlayerName == "bcc")
        {
            sc1.SetActive(false);
            bc1.SetActive(true);
           
            fc1.SetActive(false);
        }
        if (ApplicationData.PlayerName == "fcc")
        {
            sc1.SetActive(false);
            bc1.SetActive(false);
            fc1.SetActive(true);
            u1.SetActive(false);
            u2.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    { q = a.transform.position;
        konum.text = q.ToString();
        if (hareket==1)
        {
            y = y - 25;
           z = z + 30;
            a.transform.position = new Vector3(1200, y, z);

            if (y<=850&&z>=1200)
            {
                hareket = 2;
            }
        }
        if (hareket==2)
        {
            a.transform.position = new Vector3(1200, 1000, 1200);
            hareket = 0;
        }
        if (hareket==0)
        {
            a.transform.Rotate(-Input.gyro.rotationRateUnbiased.x * 2, -Input.gyro.rotationRateUnbiased.y * 2, 0);
          //  aa.text = Input.gyro.rotationRate.x.ToString();
        }
        //transform.rotation = Quaternion.Slerp(transform.rotation, _rawGyroRotation.rotation, _smoothing);
    }
    //private bool gyroEnabled;
    //private Gyroscope gyro;
    //void Start()
    //{
    //    gyroEnabled = enablegyro();
    //}
    //private bool enablegyro()
    //{
    //    if (SystemInfo.supportsGyroscope)
    //    {
    //        gyro = Input.gyro;
    //        gyro.enabled = true;
    //        return true;
    //    }

    //}

}
