using System;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using Random = UnityEngine.Random;


public class Pusher : MonoBehaviour
{
    private CoinSpawner _myCoinSpawner;
    [SerializeField] private Transform _spawnPoint;
    private PlatformSpawner _mySpawner;
    private Rigidbody _myRigidbody;
    [SerializeField] private float _speed;

    private void Awake()
    {
        _myCoinSpawner = GetComponent<CoinSpawner>();
        _mySpawner = FindObjectOfType<PlatformSpawner>();
        _myRigidbody = GetComponent<Rigidbody>();

        
        if (Random.Range(0f,1f)>0.75f)
        {
            _myCoinSpawner.SpawnCoinAt(_spawnPoint.position, this.transform);
        }

    }

    void FixedUpdate()
    {
        _myRigidbody.AddForce(-1*_speed,0,0);
    }

    private void OnTriggerExit()
    {
        
        GameObject.Destroy(this.gameObject);
        _mySpawner._platforms2Spwn++;
    }
}
