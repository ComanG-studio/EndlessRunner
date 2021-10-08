using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float CurrentScore { get; private set; }

    /// <summary>
    ///     Add given number of score to current score
    /// </summary>
    /// <param name="score"></param>
    public void AddScore(float score)
    {
        CurrentScore += score;
    }

    /// <summary>
    ///     Set current score to zero
    /// </summary>
    public void ScoreToZero()
    {
        CurrentScore = 0f;
    }
}