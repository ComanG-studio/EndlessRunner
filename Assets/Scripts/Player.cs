using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _jumpHeight = 10f;
    [SerializeField] private float _gravityScale = 1;
    private int _jumpCount;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        AddGravity();
        Jump();
    }

    private void OnCollisionEnter(Collision other)
    {
        _jumpCount = 0;
    }

    public void AddGravity()
    {
        _rigidbody.AddForce(_gravityScale * Vector3.up * -9.81f);
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _jumpCount <= 1)
        {
            _rigidbody.AddForce(Vector3.up * _jumpHeight, ForceMode.Impulse);
            _jumpCount++;
        }
    }
}