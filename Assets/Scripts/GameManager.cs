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
    public void AddScore()
    {
        FindObjectOfType<ScoreManager>().AddScore(1);
    }
}