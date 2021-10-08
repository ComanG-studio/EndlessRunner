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

        if (GameObject.FindObjectOfType<UIManager>().CheckGameInPause())
        {
            Debug.Log("Game in Pause");
            GameObject.FindObjectOfType<UIManager>().PauseResumeGameButton();
        }
        else if (GameObject.FindObjectOfType<UIManager>().CheckGameInPause() == false)
        {
            Debug.Log("Resume");
            GameObject.FindObjectOfType<UIManager>().PauseResumeGameButton();
        }


    }


}