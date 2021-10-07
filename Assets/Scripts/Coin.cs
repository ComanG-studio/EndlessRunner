using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float _spinSpeed = 200;
    [SerializeField] private Material _material;
    private MeshRenderer _meshRenderer;

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
        Destroy(gameObject);
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