using System;
using TMPro;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
    [SerializeField] private GameObject startMark;
    [SerializeField] private GameObject player;

    [SerializeField] private TextMeshProUGUI scoreText;

    [SerializeField] private int score;

    private void Awake()
    {
        this.score = 0;
    }

    private void Update()
    {
        CalculateScore(startMark.transform.position, player.transform.position);
    }

    public void CalculateScore(Vector2 startLocation, Vector2 currentLocation) {
        var distance = Vector2.Distance(new Vector2(startLocation.x, 0), new Vector2(currentLocation.x,0));
        this.score = Mathf.RoundToInt(distance * 0.9f);
        this.scoreText.text = String.Format("Score: {0}", score.ToString());
    }
    public int Score () {
        return this.score;
    }
}
