using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim1play : MonoBehaviour
{
    
        public GameObject yüzey1,yüzey2;

    public AnimationClip büyü;
    Animation anim;

    void Start()
    {
        anim = GetComponent<Animation>();
    }
    public void animvar()
    {
       
            anim.clip = büyü;
            anim.Play();
        StartCoroutine(waiter());
        
    }

    IEnumerator waiter()
    {
      
        yield return new WaitForSecondsRealtime(3);
        yüzey1.SetActive(false);
        yüzey2.SetActive(true);


    }

}
    
