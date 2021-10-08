using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager game;

    private void Awake()
    {
        if (game == null)
            game = this;
        else if (game != this)
            Destroy(gameObject);
    }

    public void AddScore()
    {
        FindObjectOfType<ScoreManager>().AddScore(1);
        Debug.Log("Score now: " + FindObjectOfType<ScoreManager>().CurrentScore);
    }
}