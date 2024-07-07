using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPopup : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI notification;

    private void OnEnable()
    {
        LoadGameOverPopup();
    }

    private void LoadGameOverPopup () {
        var saveScore = DataLoader.Instance.HighScore;
        int scoreCurrent = LevelController.Instance.ScoreCalculator().Score();
        Debug.Log(String.Format("{0}:{1}", saveScore, scoreCurrent));
        if (scoreCurrent > saveScore) {
            DataLoader.Instance.SaveScore(scoreCurrent);
            notification.text = String.Format("New High Score: {0}", scoreCurrent);
        } else {
            notification.text = "Better Luck Next Time";
        }
    }

    public void OnRestartClicked() {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void OnBackToMenuClicked() {
        SceneManager.LoadSceneAsync(0);
    }
}
