using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    private Animator flap;
    public float speed = 1f;
    private Rigidbody2D rgb2d;
    public GameObject gameOver;

    void Start()
    {
        flap = GetComponent<Animator>();
        flap.SetBool("isFly", true);
        rgb2d = GetComponent<Rigidbody2D>();
        gameOver.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space)) {
            rgb2d.velocity = Vector2.up * speed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
