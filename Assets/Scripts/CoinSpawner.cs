using System;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    /// <summary>
    ///     Spawn coin at given position
    /// </summary>
    /// <param name="position"></param>
    public void SpawnCoinAt(Vector3 position)
    {
        Instantiate(_prefab, position, _prefab.transform.localRotation);
    }

    ///<summary>
    ///     Spawn coin at given position(overload with parent)
    /// </summary>
    public void SpawnCoinAt(Vector3 position,Transform parent)
    {
        Instantiate(_prefab, position, _prefab.transform.localRotation,parent);
    }
    
}