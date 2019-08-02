using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bk2 : MonoBehaviour
{
    public GameObject selectedObject;
    //public GameObject gameobject;
    // Update is called once per frame
    public void Touch()
    {

        //if (Input.touchCount == 0)
        //{
        //    Touch touch = Input.touches[0];
        //    Ray ray = Camera.main.ScreenPointToRay(touch.position);
        //    RaycastHit hit;

        //    if (Physics.Raycast(ray, out hit, 100f))
        //    {
        //        selectedObject = hit.collider.gameObject;
        //    }
        //}
        if (Input.touchCount == 2)
        { Touch touch0 = Input.GetTouch(0);
            Touch touch1 = Input.GetTouch(1);
            if (touch0.phase == TouchPhase.Moved && touch1.phase == TouchPhase.Moved)
            {
                // Store both touches.
                Touch touchZero = Input.GetTouch(0);
                Touch touchOne = Input.GetTouch(1);

                // Find the position in the previous frame of each touch.
                Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
                Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

                // Find the magnitude of the vector (the distance) between the touches in each frame.
                float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
                float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

                // Find the difference in the distances between each frame.
                float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

                selectedObject.transform.localScale = new Vector3(deltaMagnitudeDiff, deltaMagnitudeDiff, deltaMagnitudeDiff);
            }
        }
    }

}
