using CarterGames.Assets.SaveManager;
using Save;
using UnityEngine;

public class DataLoader : Singleton<DataLoader>
{
    private PlayerScoreSaveObject playerScore;
    [SerializeField] private int highScore;
    [SerializeField] private int timeStamp;

    private void OnEnable()
    {
        playerScore = SaveManager.GetSaveObject<PlayerScoreSaveObject>();
        LoadLatestScore();
    }
    public void LoadLatestScore()
    {
        playerScore.Load();
        highScore = playerScore.score.Value;
        timeStamp = playerScore.timeStamp.Value;
    }
    public void SaveScore(int score, int timePlay) {
        playerScore.score.Value = score;
        playerScore.timeStamp.Value = timePlay;
        highScore = score;
        timeStamp = timePlay;
        playerScore.Save();
        SaveManager.Save();
    }
    public int HighScore
    {
        get { return highScore; }
    }
    public int TimeStamp
    {
        get { return timeStamp; }
    }
}