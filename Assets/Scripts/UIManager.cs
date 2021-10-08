using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text _currentScore;
    [SerializeField] private Text _pauseResumeButton;
    public float CurrentScore { get; private set; }

    public void SetScore(float score)
    {
        CurrentScore += score;
        _currentScore.text = CurrentScore.ToString();
    }

    public void PauseGame()
    {
        if (_pauseResumeButton.text == "Pause")
            _pauseResumeButton.text = "Resume";
        else if (_pauseResumeButton.text == "Resume")
            _pauseResumeButton.text = "Pause";
    }
}