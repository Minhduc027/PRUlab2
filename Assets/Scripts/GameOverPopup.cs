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
        int timeStamp = LevelController.Instance.ScoreCalculator().TimeCount();
        Debug.Log(String.Format("{0}:{1}", saveScore, scoreCurrent));
        if (scoreCurrent > saveScore) {
            DataLoader.Instance.SaveScore(scoreCurrent, timeStamp);
            notification.text = String.Format("New Record: {0}", timeStamp);
        } else {
            notification.text = "Better Luck Next Time";
        }
    }

    public void OnRestartClicked() {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void OnBackToMenuClicked() {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(0);
    }
}
