using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject pipe;
    public float height, maxTime;
    private float timer = 0f;

    void Start()
    {
        InstantiatePipe();
    }

    
    void Update()
    {
        if(timer > maxTime) {
            InstantiatePipe();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    public void InstantiatePipe() {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height));
        Destroy(newPipe, 8f);
    }
}

