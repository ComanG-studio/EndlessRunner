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

    public void AddScore()
    {
        FindObjectOfType<ScoreManager>().AddScore(1);
        Debug.Log("Score now: " + FindObjectOfType<ScoreManager>().CurrentScore);
    }
}