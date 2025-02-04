using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wgitht : MonoBehaviour
{
    public int force = 1000;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(force, 0, 0);
        }

    } // Update
}
