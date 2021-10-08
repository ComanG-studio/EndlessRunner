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

    /// <summary>
    ///     Adds 1 point to the current score
    /// </summary>
    public void AddScore(float score)
    {
        GameObject.FindObjectOfType<ScoreManager>().AddScore(score);
        GameObject.FindObjectOfType<UIManager>().SetScore(score);
    }

    /// <summary>
    /// Starts game. Score to zero, start move platforms etc.
    /// </summary>
    public void StartGame()
    {
        Debug.Log("StartGame");
        GameObject.FindObjectOfType<ScoreManager>().ScoreToZero();
        GameObject.FindObjectOfType<UIManager>().SetScore(0f);
        // Start moving platforms
    }
}