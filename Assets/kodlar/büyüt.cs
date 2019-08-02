using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class büyüt : MonoBehaviour
{
    public float defaultScaleX, defaultScaleY, defaultScaleZ;
    public float currentScaleX, currentScaleY, currentScaleZ;
    public GameObject mBundleInstance = null;
    public GameObject s1;

    float rotationSpeed = 100;
    public void Touch()
    {
        defaultScaleX = s1.transform.localScale.x;
        defaultScaleY = s1.transform.localScale.y;
        defaultScaleZ = s1.transform.localScale.z;
        currentScaleX = s1.transform.localScale.x;
        currentScaleY = s1.transform.localScale.y;
        currentScaleZ = s1.transform.localScale.z;


        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            //Debug.Log( mBundleInstance.transform.rotation.y + ":"+touchDeltaPosition.x );
            mBundleInstance.transform.Rotate(Vector3.up * -touchDeltaPosition.x * Time.deltaTime * rotationSpeed);
        }
        if (Input.touchCount == 2)
        {
            Touch touch0 = Input.GetTouch(0);
            Touch touch1 = Input.GetTouch(1);
            if (touch0.phase == TouchPhase.Moved && touch1.phase == TouchPhase.Moved)
            {
                Vector2 prevDist = (touch0.position - touch0.deltaPosition) - (touch1.position - touch1.deltaPosition);
                Vector2 curDist = touch0.position - touch1.position;
                float delta = curDist.magnitude - prevDist.magnitude;
                if (delta > 0)
                {
                    if (defaultScaleX >= currentScaleX * 4)
                    {

                    }
                    else if (defaultScaleX < currentScaleX - 0.1)
                    {

                    }
                    else if (defaultScaleX >= currentScaleX)
                    {

                        defaultScaleX = defaultScaleX + 0.03f;
                        defaultScaleY = defaultScaleY + 0.03f;
                        defaultScaleZ = defaultScaleZ + 0.03f;
                        mBundleInstance.transform.localScale = new Vector3(defaultScaleX, defaultScaleY, defaultScaleZ);
                    }
                    else
                    {

                        defaultScaleX = defaultScaleX + 0.03f;
                        defaultScaleY = defaultScaleY + 0.03f;
                        defaultScaleZ = defaultScaleZ + 0.03f;
                        mBundleInstance.transform.localScale = new Vector3(defaultScaleX, defaultScaleY, defaultScaleZ);
                    }
                }
                else if (delta < 0)
                {

                    if (defaultScaleX <= currentScaleX)
                    {

                    }
                    else if (defaultScaleX > currentScaleX)
                    {

                        defaultScaleX = defaultScaleX - 0.03f;
                        defaultScaleY = defaultScaleY - 0.03f;
                        defaultScaleZ = defaultScaleZ - 0.03f;
                        mBundleInstance.transform.localScale = new Vector3(defaultScaleX, defaultScaleY, defaultScaleZ);
                    }
                }
            }
        }
    }
}

