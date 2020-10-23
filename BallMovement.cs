using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private float ballSpeed = 4f;
    private bool firstColl = false;
    private bool startGame = false;

    private Vector3 incomingVector;
    private Vector3 normalVector;
    private Vector3 reflectVector;

    private Vector3 firstPos;
    private Vector3 collisionPos;

    void Start()
    {
        firstPos = this.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject != null)
        {
            firstColl = true;
            collisionPos = this.transform.position;
        }

        if(firstColl == true)
        {
            incomingVector = (collisionPos - firstPos).normalized;
            normalVector = collision.contacts[0].normal;                
            reflectVector = Vector3.Reflect(incomingVector, normalVector).normalized;
            firstPos = collisionPos;
        }
    }

    void FixedUpdate()
    {
        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0f);

        if (Input.GetKeyDown(KeyCode.Space)) startGame = true;

        if (startGame == true && firstColl == false)
        {
            this.transform.parent = null;
            this.gameObject.transform.position += new Vector3(1f, 1f, 0f).normalized * Time.deltaTime * ballSpeed;
        }
        if(firstColl == true)
        {
            this.transform.position += reflectVector * Time.deltaTime * ballSpeed;
        }
    }
}
