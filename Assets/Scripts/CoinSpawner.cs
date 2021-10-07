using System;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    /// <summary>
    ///     Spawn coin at given position
    /// </summary>
    /// <param name="position"></param>
    private void SpawnCoinAt(Vector3 position)
    {
        Instantiate(_prefab, position, _prefab.transform.localRotation);
    }

    private void Start()
    {
        SpawnCoinAt(new Vector3(0,10,0));
    }
}