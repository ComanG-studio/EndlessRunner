using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text _currentScore;
    [SerializeField] private Text _pauseResumeButtonLable;
    [SerializeField] private Button _pauseResumeButton;
    public float CurrentScore { get; private set; }

    public void SetScore(float score)
    {
        CurrentScore += score;
        _currentScore.text = CurrentScore.ToString();
    }

    public void Resume()
    {
        if (_pauseResumeButtonLable.text == "Pause") _pauseResumeButtonLable.text = "Resume";
    }

    public void Pause()
    {
        if (_pauseResumeButtonLable.text == "Resume") _pauseResumeButtonLable.text = "Pause";
    }

    public bool CheckGameInPause()
    {
        if (_pauseResumeButtonLable.text == "Pause") return true;

        return false;
    }

    public void ShowPauseResumeButton()
    {
        _pauseResumeButton.gameObject.SetActive(true);
    }

    public void HidePauseResumeButton()
    {
        _pauseResumeButton.gameObject.SetActive(false);
    }
}