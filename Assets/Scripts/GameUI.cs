using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Slider healthbar;
    public Text scoreText;

    public int playerScore = 0;

    private void OnEnable()
    {
        Player.onUpdateHealth += UpdateHealthBar;
        AddScore.onSendScore += UpdateScore;
    }

    private void OnDisable()
    {
        Player.onUpdateHealth -= UpdateHealthBar;
        AddScore.onSendScore -= UpdateScore;
    }

    private void UpdateHealthBar(int health)
    {
        healthbar.value = health;  
    }

    private void UpdateScore(int theScore)
    {
        playerScore += theScore;
        scoreText.text = "SCORE" + theScore.ToString();
    }







}
