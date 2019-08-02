using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrkod : MonoBehaviour
{
    public GameObject sc1, bc1, fc1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sc() {
        sc1.SetActive(true);
        bc1.SetActive(false);
        fc1.SetActive(false);
    }
    public void bcc() {
        sc1.SetActive(false);
        bc1.SetActive(true);
        fc1.SetActive(false);
    }
    public void fcc() {
        sc1.SetActive(false);
        bc1.SetActive(false);
        fc1.SetActive(true);
    }
}
