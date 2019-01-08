using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public struct HighScores
{
    public List<int> scores;
}
public class HighScoreUI : MonoBehaviour
{
    public Text highscoreText;
    public HighScores highscore;
    private int totalHighScores = 5;

    private void Start()
    {
        int score = PlayerPrefs.GetInt("Score");
        string s = PlayerPrefs.GetString("Highscores");

        if (string.IsNullOrEmpty(s))
        {
            highscore = new HighScores();
            highscore.scores = new List<int>();
        }
        else
        {
            highscore = JsonUtility.FromJson<HighScores>(s);
        }

        if (highscore.scores.Count < totalHighScores)
        {
            int amount = totalHighScores - highscore.scores.Count;
            for (int i = 0; i < amount; i++)
            {
                highscore.scores.Add(0);
            }
        }

        if (score > highscore.scores[totalHighScores - 1]) ;
        {
            highscore.scores[totalHighScores - 1] = score;
        }

        highscore.scores.Sort();
        highscore.scores.Reverse(0, totalHighScores);

        highscoreText.text = "HIGH SCORES\n";

        for (int i = 0; i < totalHighScores; i++)
        {
            if (highscore.scores[i] == score) 

            {
                highscoreText.text += "<color=#FF0000FF>" + (i + 1).ToString() + "."
                    + highscore.scores[i].ToString() + "<color>\n";
            }
            else
            {
                highscoreText.text += (i + 1).ToString() + "." + highscore.scores[i].ToString() + "\n";
            }
        }

        string scoresJSON = JsonUtility.ToJson(highscore);
        PlayerPrefs.SetString("HighScores", scoresJSON);
    }


}
