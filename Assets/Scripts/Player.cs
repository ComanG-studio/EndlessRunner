using UnityEngine;

public class Player : MonoBehaviour
{
    private float _jumpHeight = 15f;
    private float _gravityScale = 1;
    private bool _firstJump;
    private int _jumpCount;
    private Rigidbody _rigidbody;
    private float _gravity = -9.8f;

    private void Awake()
    {
        _firstJump = true;
    }

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        StartBall();
    }

    private void Update()
    {
        AddGravity();
        Jump();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Platform")
        {
            _jumpCount = 0;
        }
    }

    public void AddGravity()
    {
        _rigidbody.AddForce(_gravityScale * Vector3.up * _gravity);
    }

    /// <summary>
    /// Ball do jump
    /// </summary>
    public void Jump()
    {
        // if this is the first jump ever, then Start Game
        if (CheckFirstJump())
        {
            GameManager.game.StartGame();
            _rigidbody.AddForce(Vector3.up * _jumpHeight, ForceMode.Impulse);
            _firstJump = false;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && _jumpCount <= 1)
        {
            _rigidbody.AddForce(Vector3.up * _jumpHeight, ForceMode.Impulse);
            _jumpCount++;
        }
    }

    /// <summary>
    ///     Check if the ball do his first jump ever
    /// </summary>
    /// <returns></returns>
    public bool CheckFirstJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _firstJump)
            return true;
        return false;
    }

    public void StopBall()
    {
        _jumpHeight = 0;
        _gravityScale = 0;
        _gravity = 0;
        _rigidbody.Sleep();

    }

    public void StartBall()
    {
        _jumpHeight = 10f;
        _gravityScale = 1;
        _gravity = -9.8f;
        _rigidbody.WakeUp();

    }
}