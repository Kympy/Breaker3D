using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleEffect : MonoBehaviour
{
    public GameObject bricks;

    private float createTime;
    private Transform[] spawnPoints;

    void Start()
    {
        spawnPoints = GameObject.Find("SpawnPoints").GetComponentsInChildren<Transform>();
        createTime = 1.5f;
        StartCoroutine(FallingBricks());
    }

    IEnumerator FallingBricks()
    {
        while(true)
        {
            int index = Random.Range(1, spawnPoints.Length);
            Instantiate(bricks, spawnPoints[index].position, Quaternion.identity);

            yield return new WaitForSeconds(createTime);
        }
    }
}
