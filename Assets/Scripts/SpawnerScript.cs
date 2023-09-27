using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    //array
    public GameObject[] Toys;

    public float T;
    private float SpawnTime = 0.8f;

    void Update()
    {

        T = Time.time;

        if (Time.time >= SpawnTime)
        {
            SpawnTime += 1.7f;

            //choose random array object
            int a = Random.Range(0, Toys.Length);

            //instantiate
            Instantiate(Toys[a], new Vector3(Random.Range(-0.5f, 0.5f), 3f, Random.Range(-0.5f, 0.5f)), Quaternion.identity);

        }
    }
}
