using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float DogTime = -1f;

    private float DogDelay = 2.5f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog with a delay till you can spawn the next one
        if (Input.GetKeyDown(KeyCode.Space) && DogTime <= Time.time)
        {
            DogTime = Time.time + DogDelay;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
