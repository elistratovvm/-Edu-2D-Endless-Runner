using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public GameObject barrier;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(barrier, transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
