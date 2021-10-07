using System;
using Unity.VisualScripting;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    private Rigidbody _myRigidbody;
    [SerializeField]
    private float _speed;

    private void Awake()
    {
        _myRigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        _myRigidbody.velocity = Vector3.right * _speed;
    }

            private void OnCollisionEnter(Collision other)
            {
                if (other.gameObject.tag == "Wall") 
                {
                    GameObject.Destroy(this);
                }
            }
}
