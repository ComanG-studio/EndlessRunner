using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public float CurrentScore { get; private set; }
    [SerializeField] private Text _currentScoreLable;

    public void AddScore(float score)
    {
        CurrentScore += score;
        _currentScoreLable.text = CurrentScore.ToString();
    }
}