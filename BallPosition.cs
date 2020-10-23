using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPosition : MonoBehaviour
{
    public Transform ballPosition;
    public GameObject ball;

    private bool isGaming = false;

    private void Start()
    {

    }
    void FixedUpdate()
    {
        if (isGaming == false)
        {
            Instantiate(ball, ballPosition);
            isGaming = true;
        }

    }
}
