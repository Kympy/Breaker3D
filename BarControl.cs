using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BarControl : MonoBehaviour
{
    private float barSpeed;

    void Start()
    {
        barSpeed = 4.5f;
    }

    void FixedUpdate()
    {
        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, -2.31f, 0f);
        this.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, -90f);

        if(Input.GetKey(KeyCode.D) == true)
        {
            this.gameObject.transform.position += Vector3.right * barSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A) == true)
        {
            this.gameObject.transform.position += Vector3.left * barSpeed * Time.deltaTime;
        }
    }
}
