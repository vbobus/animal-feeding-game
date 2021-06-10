using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); //spawn animal at regular intervals
    }

    // Update is called once per frame
    void Update()
    {


    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);      //pick any animal from 0-2 randomly
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, -spawnRangeX), 0, spawnPosZ);    //pick any position in spawnrangeX randomly
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation); //instantiate animals randomly at random location
    }
}
