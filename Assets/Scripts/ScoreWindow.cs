using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreWindow : MonoBehaviour
{
    private static ScoreWindow instance;

    private Text scoreText;

    private void Awake()
    {
        instance = this;

        scoreText = transform.Find("ScoreText").GetComponent<Text>();
        Score.OnHighscoreChanged += Score_OnHighscoreChanged;
        UpdateHighscore();
    }

    private void Score_OnHighscoreChanged(object sender, System.EventArgs e)
    {
        UpdateHighscore();
    }

    private void UpdateHighscore()
    {
        int highscore = Score.GetHighScore();
        transform.Find("highScoreText").GetComponent<Text>().text = "HIGHSCORE\n" + highscore.ToString();
    }

    private void Update()
    {
        scoreText.text = Score.GetScore().ToString();
    }

    public static void HideStatic()
    {
        instance.gameObject.SetActive(false);
    }

}
