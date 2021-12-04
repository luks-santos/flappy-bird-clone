using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControl : MonoBehaviour
{
    private Animator flap;

    // Start is called before the first frame update
    void Start()
    {
        flap = GetComponent<Animator>();
        flap.SetBool("isFly", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
