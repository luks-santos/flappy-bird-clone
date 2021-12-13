using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesController : MonoBehaviour
{
    public float velocity;

    void Update()
    {
        transform.position += Vector3.left * velocity * Time.deltaTime;
    }
}
