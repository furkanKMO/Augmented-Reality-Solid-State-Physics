using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DROPDOWN : MonoBehaviour
{
   public RectTransform container;
    bool isOpen;
    void Start() {
        container = transform.Find("Container").GetComponent<RectTransform>();
        isOpen = false;


    }
    void Update() {
        Vector3 scale = container.localScale;
        scale.y = Mathf.Lerp(scale.y,isOpen? 1:0, Time.deltaTime * 12);
        container.localScale = scale;
    }
    public void isopen() {

        if (isOpen==false)
        {
            isOpen = true;
        }
        else
        {
            isOpen = false;
        }


    }
}
