using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    // destroys objects when they collide
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
