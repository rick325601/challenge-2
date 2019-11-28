using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22f;
    private float spawnLimitXRight = 7f;
    private float spawnPosY = 30f;

    private float startDelay = 1.0f;

    private float spawndelay = 1.0f;
    private float spawndelaymin = 3.0f;
    private float spawndelaymax = 5.0f;

    // Start is called before the first frame update
    void Update()
    {
        //makes the balls spawn at random times
        if (spawndelay <= Time.time)
        {
            spawndelay = Time.time + Random.Range(spawndelaymin, spawndelaymax);
            SpawnRandomBall();
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
