using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMovement : MonoBehaviour
{
    public int speed = 10;
    public int jumpForce;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpForce = 500;
        }
        else
        {
            jumpForce = 0;
        }

        GetComponent<Rigidbody>().AddForce(h, jumpForce, v);

    }// Update
}