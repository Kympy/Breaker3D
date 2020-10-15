using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontMove : MonoBehaviour
{
    private Vector3 originalPos;
    private Quaternion originalRot;

    void Start()
    {
        originalPos = this.transform.position;
        originalRot = this.transform.rotation;
    }
    void FixedUpdate()
    {
        this.transform.position = originalPos;
        this.transform.rotation = originalRot;
    }
}
