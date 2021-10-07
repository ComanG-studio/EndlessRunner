using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float jumpSpeed = 5f;
    private Rigidbody rigidbody;
    private bool onGround;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    
}
