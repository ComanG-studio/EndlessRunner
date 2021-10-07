using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private float _currentScore;

    public float CurrentScore
    {
        get => _currentScore;
        private set => _currentScore = value;
    }

    /// <summary>
    /// Add given number of score to current score
    /// </summary>
    /// <param name="score"></param>
    public void AddScore(float score)
    {
        CurrentScore += score;
    }
}
