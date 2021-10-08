using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlatformSpawner : MonoBehaviour
{
    private float _nextSpawn;
    [SerializeField]
    private Transform _platformPrefab;
   public float MsBtweenSpawn =100f;
   public int _platforms2Spwn = 0;

   private void Update()
   {

   }
   /*
   void Spawn(){
         if (_platforms2Spwn!=0 && Time.time>_nextSpawn){


           Instantiate(_platformPrefab,
               new Vector3(this.transform.position.x, this.transform.position.y + Random.Range(-3f, 4f), 0),
               Quaternion.identity,
               this.transform);
           _nextSpawn = Time.time + MsBtweenSpawn;
           _platforms2Spwn--;
        }
   }
    */
}
