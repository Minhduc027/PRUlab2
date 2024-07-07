using CarterGames.Assets.SaveManager;
using Save;
using UnityEngine;

public class DataLoader : Singleton<DataLoader>
{
    private PlayerScoreSaveObject playerScore;
    [SerializeField] private int highScore;

    private void OnEnable()
    {
        playerScore = SaveManager.GetSaveObject<PlayerScoreSaveObject>();
        LoadLatestScore();
    }
    public void LoadLatestScore()
    {
        playerScore.Load();
        highScore = playerScore.score.Value;
    }
    public void SaveScore(int score) {
        playerScore.score.Value = score;
        playerScore.Save();
        SaveManager.Save();
    }
    public int HighScore
    {
        get { return highScore; }
    }
}