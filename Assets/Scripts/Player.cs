using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float jumpSpeed = 5f;
    private Rigidbody _rigidbody;
    private bool _onGround = true;
    private int maxJump = 2;
    private int currentJump;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("space") && (_onGround || maxJump > currentJump))
        {
            _rigidbody.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            _onGround = false;
            currentJump++;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        _onGround = true;
        currentJump = 0;
    }
}
