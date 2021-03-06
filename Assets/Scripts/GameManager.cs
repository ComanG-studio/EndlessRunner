using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager game;

    public bool IsGameStarted { get; private set; }

    private void Awake()
    {
        if (game == null)
            game = this;
        else if (game != this)
            Destroy(gameObject);
        GameObject.FindObjectOfType<UIManager>().HidePauseResumeButton();
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
        IsGameStarted = true;
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
            IsGameStarted = false;
        }
        else if (FindObjectOfType<UIManager>().CheckGameInPause() == false) // Resume
        {
            Debug.Log("Resume");
            FindObjectOfType<UIManager>().Pause();
            FindObjectOfType<Player>().StartBall();
            IsGameStarted = true;
        }
    }
}