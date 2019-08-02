using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sahnedegis : MonoBehaviour
{
    public GameObject uyari;


    public void sahne1()
    {
        if (ApplicationData.PlayerName == "sc" || ApplicationData.PlayerName == "bcc" || ApplicationData.PlayerName == "fcc")
        {
            SceneManager.LoadScene("sahne1");
        }


    }
    public void sahne2()
    {
        if (ApplicationData.PlayerName == "sc" || ApplicationData.PlayerName == "bcc" || ApplicationData.PlayerName == "fcc")
        {
            SceneManager.LoadScene("sahne2");
        }
        if (string.IsNullOrEmpty(ApplicationData.PlayerName) || ApplicationData.PlayerName== "Model Seçin.")
        {
            uyari.gameObject.SetActive(true);
        }



    }
    public void sahne4enyakin()
    {
        if (ApplicationData.PlayerName == "sc" || ApplicationData.PlayerName == "bcc" || ApplicationData.PlayerName == "fcc")
        {
            SceneManager.LoadScene("sahne4enyakin");
        }
        if (string.IsNullOrEmpty(ApplicationData.PlayerName) || ApplicationData.PlayerName == "Model Seçin.")
        {
            uyari.gameObject.SetActive(true);
        }



    }
    public void sahne5ikincienyakin()
    {
        if (ApplicationData.PlayerName == "sc" || ApplicationData.PlayerName == "bcc" || ApplicationData.PlayerName == "fcc")
        {
            SceneManager.LoadScene("sahne5ikincienyakin");
        }
        if (string.IsNullOrEmpty(ApplicationData.PlayerName) || ApplicationData.PlayerName == "Model Seçin.")
        {
            uyari.gameObject.SetActive(true);
        }



    }
    public void katla()
    {
        if (ApplicationData.PlayerName == "sc" || ApplicationData.PlayerName == "bcc" || ApplicationData.PlayerName == "fcc")
        {
            SceneManager.LoadScene("sahne3katlama");
        }else {
            uyari.gameObject.SetActive(true);
        }
      
    }
}
