﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cevir : MonoBehaviour
{
    float rotspeed = 70;
    public void OnMouseDrag() {
        float rotX = Input.GetAxis("Mouse X") * rotspeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotspeed * Mathf.Deg2Rad;
        transform.Rotate(Vector3.up, -rotX);
        transform.Rotate(Vector3.right, rotY);
    }
}
