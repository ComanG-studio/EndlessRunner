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
        FindObjectOfType<ScoreManager>().AddScore(score);
        FindObjectOfType<UIManager>().SetScore(score);
    }

    /// <summary>
    ///     Starts game. Score to zero, start move platforms etc.
    /// </summary>
    public void StartGame()
    {
        Debug.Log("StartGame");
        FindObjectOfType<ScoreManager>().ScoreToZero();
        FindObjectOfType<UIManager>().SetScore(0f);
        FindObjectOfType<UIManager>().ShowPauseResumeButton();
        // Start moving platforms
    }

    /// <summary>
    ///     Pause and resume game button
    /// </summary>
    public void PauseResumeGame()
    {
        if (FindObjectOfType<UIManager>().CheckGameInPause()) // Pause
        {
            Debug.Log("Game in Pause");
            FindObjectOfType<UIManager>().Resume();
            FindObjectOfType<Player>().StopBall();
            // stop moving platforms
        }
        else if (FindObjectOfType<UIManager>().CheckGameInPause() == false) // Resume
        {
            Debug.Log("Resume");
            FindObjectOfType<UIManager>().Pause();
            FindObjectOfType<Player>().StartBall();
            // start moving platforms
        }
    }
}