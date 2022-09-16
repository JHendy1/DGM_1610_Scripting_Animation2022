using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPrefabs; // Array to store balloon game object
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;
    public float xRange = 10.0f; 

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval); //Continuously spawns balloons
    }

   void SpawnRandomBalloon()
    {
        //Get a random position on x-axis
        Vector3 SpawnPos = new Vector3(Random.Range(-xRange, xRange), (float)10.0);

        //Pick Random balloon from balloon array
        int balloonIndex = Random.Range(0, balloonPrefabs.Length);

        //Spawn random balloon at spawn position
        Instantiate(balloonPrefabs[balloonIndex], SpawnPos, balloonPrefabs[balloonIndex].transform.rotation);
    }
}
