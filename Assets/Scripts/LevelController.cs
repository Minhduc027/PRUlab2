using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : Singleton<LevelController>
{
    [SerializeField] private ScoreCalculator scoreCalculator;
    [SerializeField] private GameObject gameOver;

    public GameObject GameOver () {
        return gameOver;
    }

    public ScoreCalculator ScoreCalculator () {
        return scoreCalculator;
    }
}
