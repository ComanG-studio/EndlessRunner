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

    /// <summary>
    /// Pause and resume game button
    /// </summary>
    public void PauseResumeGame()
    {

        if (GameObject.FindObjectOfType<UIManager>().CheckGameInPause()) // Pause
        {
            Debug.Log("Game in Pause");
            GameObject.FindObjectOfType<UIManager>().Resume();
            GameObject.FindObjectOfType<Player>().StopBall();
            // stop moving platforms
        }
        else if (GameObject.FindObjectOfType<UIManager>().CheckGameInPause() == false) // Resume
        {
            Debug.Log("Resume");
            GameObject.FindObjectOfType<UIManager>().Pause();
            GameObject.FindObjectOfType<Player>().StartBall();
            // start moving platforms
        }
    }


}