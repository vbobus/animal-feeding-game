using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 35;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound) //pizza boundary
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound) //animal boundary
        {
            Destroy(gameObject);
            Debug.Log("GAME OVER !!!");
        }
    }
}
