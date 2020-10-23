using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksControl : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            Destroy(this.gameObject);
        }
    }

}
