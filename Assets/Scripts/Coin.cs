using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private Material _material;
    private MeshRenderer _meshRenderer;
    private readonly float _spinSpeed = 200;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _meshRenderer.material = _material;
    }

    private void Update()
    {
        Spin();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerBall")
        {
            GameManager.game.AddScore(1);
            Destroy(this.gameObject);
        }
    }

    /// <summary>
    ///     Rotates around its y axis (World space)
    /// </summary>
    public void Spin()
    {
        var speed = _spinSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, speed, Space.World);
    }
}