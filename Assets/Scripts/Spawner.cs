using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] barrierVariants;

    private float timeBetweenSpawn;
    public float startTimeBetweenSpawn;
    public float decreaseTime;
    public float minTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBetweenSpawn < 0)
        {
            int rand = Random.Range(0, barrierVariants.Length);
            Instantiate(barrierVariants[rand], transform);
            timeBetweenSpawn = startTimeBetweenSpawn;

            if (startTimeBetweenSpawn > minTime)
            {
                startTimeBetweenSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBetweenSpawn -= Time.deltaTime;
        }
    }

}
