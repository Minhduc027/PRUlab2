using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : Singleton<LevelController>
{
    [SerializeField] private ScoreCalculator scoreCaculator;

    public ScoreCalculator ScoreCalculator () {
        return scoreCaculator;
    }
}
