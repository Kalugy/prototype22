using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30f;

    private float startDelay = 1.0f;
    //private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        //float randomIndex = Random.Range(1f, 5f);

        //InvokeRepeating("SpawnRandomBall", startDelay, randomIndex);


        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int randomIndex = Random.Range(0, 2);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomIndex], spawnPos, ballPrefabs[randomIndex].transform.rotation);

        float randomStart = Random.Range(1f, 5f);
        Invoke("SpawnRandomBall", randomStart);
    }

}
