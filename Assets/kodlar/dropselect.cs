using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropselect : MonoBehaviour
{
    public GameObject sc, bcc, fcc;
    GameObject scclone, bcclone, fcclone;
    //List<GameObject> bclist,fclist,sclist;
    public Text b;
    
    
    int a = 40;
   // int sayisc = 0, sayibc = 0,sayifc=0;
    public void selectSC() {
       
        a = int.Parse(b.text);
        scclone = Instantiate(sc, new Vector3(a, 40, 0), Quaternion.identity) as GameObject;
        scclone.SetActive(true);
        //sclist.Add(sc.gameObject);
        a = a + 50;
        b.text = a.ToString(); ;
       // sc.SetActive(true);
    }
    public void selectBCc()
    {
        a = int.Parse(b.text);
        bcclone = Instantiate(bcc, new Vector3(a, 40, 0), Quaternion.identity) as GameObject;
        bcclone.SetActive(true);
       // bclist.Add(bcc.gameObject);
        a = a + 50;
        b.text = a.ToString(); ;
        //bcc.SetActive(true);
    }
    public void selectFCC()
    {
        a = int.Parse(b.text);
        fcclone = Instantiate(fcc, new Vector3(a, 40, 0), Quaternion.identity) as GameObject;
        fcclone.SetActive(true);
        //fclist.Add(fcc.gameObject);
        a = a + 50;
        b.text = a.ToString(); ;
        // fcc.SetActive(true);
    }
    public void del() {
        a = 40;
        b.text = "40";
        sc.SetActive(false);
        bcc.SetActive(false);
        fcc.SetActive(false);
        
    }
}
