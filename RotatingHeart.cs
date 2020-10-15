using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingHeart : MonoBehaviour
{
    private Vector3 rotationAngle = new Vector3(0, 0, 10f);
    private float rotationSpeed = 10f;


    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(rotationAngle * rotationSpeed * Time.deltaTime);
    }
}
