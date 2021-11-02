using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField] private float _platformMoveSpeed = 5;
    [SerializeField] private GameObject _platformPrefab_1;
    [SerializeField] private GameObject _platformPrefab_2;
    private readonly int _platformCount = 10;
    private readonly List<GameObject> _platforms = new List<GameObject>();

    private void Start()
    {
        StartLevel();
    }

    private void Update()
    {
        if (GameManager.game.IsGameStarted == true)
        {
            foreach (var platform in _platforms) MovePlatform(platform);
        }

        if (_platforms[0].transform.position.x < -6)
        {
            Destroy(_platforms[0]);
            _platforms.RemoveAt(0);
            CreateRandomPlatform();
        }
    }

    public void StartLevel()
    {
        for (var i = 0; i < _platformCount; i++) CreateRandomPlatform();
    }

    public void MovePlatform(GameObject platform)
    {
        platform.transform.position -= Vector3.right * _platformMoveSpeed * Time.deltaTime;
    }

    public void CreateRandomPlatform()
    {
        var randomPlatformType = Random.Range(0, 2);
        switch (randomPlatformType)
        {
            case 0:
                CreateNewPlatform(_platformPrefab_1);
                break;
            case 1:
                CreateNewPlatform(_platformPrefab_2);
                break;
        }
    }

    public void CreateNewPlatform(GameObject platformPrefab)
    {
        var newPlatformPosition = Vector3.zero;
        if (_platforms.Count > 0)
            newPlatformPosition = _platforms[_platforms.Count - 1].transform.position + new Vector3(7f, Random.Range(-1f, 1f), 0f);

        var newPlatform = Instantiate(platformPrefab, newPlatformPosition, Quaternion.identity);
        _platforms.Add(newPlatform);
    }
}