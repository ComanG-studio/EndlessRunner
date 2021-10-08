using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _jumpHeight = 10f;
    [SerializeField] private float _gravityScale = 1;
    private bool _firstJump;
    private int _jumpCount;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _firstJump = true;
    }

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
        if (other.collider.tag == "Platform")
        {
            _jumpCount = 0;
        }
    }

    public void AddGravity()
    {
        _rigidbody.AddForce(_gravityScale * Vector3.up * -9.81f);
    }

    public void Jump()
    {
        // if this is the first jump ever, then Start Game
        if (CheckFirstJump())
        {
            GameManager.game.StartGame();
            _firstJump = false;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && _jumpCount <= 1)
        {
            _rigidbody.AddForce(Vector3.up * _jumpHeight, ForceMode.Impulse);
            _jumpCount++;
        }
    }//

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
    //asdfasdf
}