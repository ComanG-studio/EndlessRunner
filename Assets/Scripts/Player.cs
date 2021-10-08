using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private float _jumpForce = 10f;
    private int jumpCount = 0;
    [SerializeField] private float _gravityscale = 1;

    private bool isGrounded = false;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        jumpCount = 0;
    }

    private void Update()
    {
        AddGravity();
        Jump();
    }

    public void AddGravity()
    {
        _rigidbody.AddForce(_gravityscale * Vector3.up * -9.81f);
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount <= 1)
        {
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            jumpCount++;
        }
    }

}
