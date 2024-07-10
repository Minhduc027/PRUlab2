using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
    [SerializeField] private GameObject startMark;
    [SerializeField] private GameObject player;

    [SerializeField] private TextMeshProUGUI scoreText;

    [SerializeField] private int score;
    [SerializeField] private int timeCount;

    private void Awake()
    {
        this.score = 0;
        this.timeCount = 0;
        StartCoroutine(UpdateTimePlay());
    }

    private void Update()
    {
        CalculateScore(startMark.transform.position, player.transform.position);
    }

    public void CalculateScore(Vector2 startLocation, Vector2 currentLocation) {
        var distance = Vector2.Distance(new Vector2(startLocation.x, 0), new Vector2(currentLocation.x,0));
        this.score = Mathf.RoundToInt(distance * 0.9f);
        UpdateTimerText();
    }
    public int Score () {
        return this.score;
    }

    public int TimeCount() {
        return this.timeCount;
    }

    IEnumerator UpdateTimePlay() {
        while (!PlayerController.Instance.IsGameOver) {
            yield return new WaitForSeconds(1);
            this.timeCount++;
        }
    }

    private void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(timeCount / 60);
        int seconds = Mathf.FloorToInt(timeCount % 60);
        this.scoreText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
