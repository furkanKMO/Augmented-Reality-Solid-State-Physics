using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bccselect : MonoBehaviour
{
    private string sec = "", acık, formül1,formül2;
    public Text a;
    public Text acıklama, formü1,formü2;
    public GameObject fcc,bcc,sc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    { sec = "bcc";
        a.text = sec;
        acık = "Hacim Merkezli Kübik Kafes sistemi (cI) sekiz köşe noktalasına ek olarak birim hücre merkezinde bir kafes noktasına sahiptir. Birim hücre toplamda iki atom içerir.(1⁄8 × 8 + 1).";
        formül1 = "2=8*(1/8)+1";
        formü1.text = formül1;
        formül2 = "8 adet komşu yeşil renkte belirtilmiştir.";
        formü2.text = formül2;
        acıklama.text = acık;
        bcc.gameObject.SetActive(true);
        fcc.gameObject.SetActive(false);
        sc.gameObject.SetActive(false);
    }
}
