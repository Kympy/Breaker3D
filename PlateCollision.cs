using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlateCollision : MonoBehaviour
{
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            if (timer >= 2f)
            {
                Destroy(collision.gameObject);
                timer = 0f;
            }
        }
    }
}
