using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scselect : MonoBehaviour
{
    private string sec = "", acık, formül1,formül2;
    public Text a;
    public Text acıklama, formü1,formü2;
    public GameObject fcc, bcc, sc;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnMouseDown()
    {
        sec = "sc";
        a.text = sec;
        acık = "Basit kübik kafes örgüsünde (cP) küpün her köşesinde tek bir kafes noktası oluşur. Bir kafes noktasında her atom sekiz komşu küp arasında paylaşılır ve birim hücre bu nedenle toplam tek atom içerir. (1⁄8 × 8). ";
        formül1 = "1=8*(1/8)";
        formü1.text = formül1;
        formül2 = "6 adet komşu yeşil renkte belirtilmiştir.";
        formü2.text = formül2;
        acıklama.text = acık;
        bcc.gameObject.SetActive(false);
        fcc.gameObject.SetActive(false);
        sc.gameObject.SetActive(true);
    }
}
