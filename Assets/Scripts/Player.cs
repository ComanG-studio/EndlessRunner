using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float _jumpForce = 1f;
    private int jumpCount = 0;
    private int extraJumps;
    private int extraJumpsValue;
    private bool isGrounded;


    private void Start()
    {
        extraJumps = extraJumpsValue;
        _rb = GetComponent<Rigidbody>();
    }



    private void Update()
    {
        if (isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }

        if (Input.GetKeyDown(KeyCode.Space) && extraJumps <= 1)
        {
            _rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            jumpCount++;
        } 

    }

}