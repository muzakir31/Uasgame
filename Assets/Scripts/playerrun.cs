using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerRun : MonoBehaviour
{
    public Rigidbody2D rb;
    public float runSpeed = 5f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * runSpeed;
        }
    }
}


