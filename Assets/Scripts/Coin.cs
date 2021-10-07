using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float _spinSpeed;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Material _material;

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

    /// <summary>
    ///     Instantiate an instance of a coin at a given point
    /// </summary>
    public void CreateCoin(Vector3 spawnPosition)
    {
        var newCoin = Instantiate(_prefab, spawnPosition, Quaternion.identity);
    }
}