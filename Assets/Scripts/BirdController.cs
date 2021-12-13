using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    private Animator flap;
    public float speed = 1f;
    private Rigidbody2D rgb2d;

    // Start is called before the first frame update
    void Start()
    {
        flap = GetComponent<Animator>();
        flap.SetBool("isFly", true);
        rgb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)) {
            rgb2d.velocity = Vector2.up * speed;
        }
    }
}
