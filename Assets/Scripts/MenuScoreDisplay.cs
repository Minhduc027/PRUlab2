using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuScoreDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private TextMeshProUGUI time;
    // Start is called before the first frame update
    private void OnEnable()
    {
        score.text = String.Format("Score: {0}", DataLoader.Instance.HighScore);
        int timeCount = DataLoader.Instance.TimeStamp;
        int minutes = Mathf.FloorToInt(timeCount / 60);
        int seconds = Mathf.FloorToInt(timeCount % 60);
        time.text = String.Format("Fastest Time: {0:00}:{1:00}",minutes,seconds);
    }
}
