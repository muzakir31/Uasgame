using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerjump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
