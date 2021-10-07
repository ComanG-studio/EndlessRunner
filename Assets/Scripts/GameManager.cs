using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _gameManager;

    private void Awake()
    {
        if (_gameManager == null)
            _gameManager = this;
        else if (_gameManager != this)
            Destroy(gameObject);
    }
}