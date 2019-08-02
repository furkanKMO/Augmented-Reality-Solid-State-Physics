using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fccselect : MonoBehaviour
{
    private string sec = "",acık,formül1,formül2;
    
    public Text a;
    public Text acıklama ,formü1,formü2;
    public GameObject fcc, bcc, sc;
    // Start is called before the first frame update


    private void OnMouseDown()
    {
        sec = "fcc";
        a.text = sec;
        acık = "Yüzey Merkezli Kübik Kafes sistemi (cF) Küpün yüzlerinde örgü noktalarına sahiptir, bu örgü noktalarının her biri yarım atom içermektedir bu sistem toplamda dört atom içerir (1⁄8 × 8 köşe noktalarından 1⁄2 × 6 yüzey noktalarından)";
        formül1 = "4=8*(1/8)+6*(1/8)";
        formü1.text = formül1;
        formül2 = "12 adet komşu yeşil renkte belirtilmiştir. adet komşu yeşil renkte belirtilmiştir.";
        formü2.text = formül2;
        acıklama.text = acık;
        bcc.gameObject.SetActive(false);
        fcc.gameObject.SetActive(true);
        sc.gameObject.SetActive(false);

    }
    
}
