using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Prateek;
using Prateek.Utils;



public class GameHandler : MonoBehaviour
{

    private static GameHandler instance;

    //private static int score;

    [SerializeField] private Snake snake;

    private LevelGrid levelGrid;

    private void Awake()
    {
        instance = this;
        Score.InitializeStatic();
        Time.timeScale = 1f;

        //Score.TrySetNewHighScore(200);


        //PlayerPrefs.SetInt("highscore", 1000);
        //PlayerPrefs.Save();
        //Debug.Log(PlayerPrefs.GetInt("highscore"));
    }

    void Start()
    {
        Debug.Log("GameHandler.Start");

        levelGrid = new LevelGrid(20, 20);

        snake.SetUp(levelGrid);
        levelGrid.SetUp(snake);

        //CMDebug.ButtonUI(Vector2.zero, "Reload Scene", () =>
        // {
        //     Loader.Load(Loader.Scene.GameScene);
        // });
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsGamePaused())
            {
                GameHandler.ResumeGame();
            }
            else
            {
                GameHandler.PauseGame();
            }
            
        }
    }


    public static void SnakeDied()
    {
        bool isNewHighscore = Score.TrySetNewHighScore();
        GameOverWindow.ShowStatic(isNewHighscore);
        ScoreWindow.HideStatic();
    }


    public static void ResumeGame()
    {
        PauseWindow.HideStatic();
        Time.timeScale = 1f;
    }

    public static void PauseGame()
    {
        PauseWindow.ShowStatic();
        Time.timeScale = 0f;
    }

    public static bool IsGamePaused()
    {
        return Time.timeScale == 0f;
    } 
}
