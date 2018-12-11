using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public delegate void SendScore(int thescore);
    public static event SendScore onSendScore;

    public int score = 10;
    private bool scoreSent = false;

    private void OnAddScore()
    {
        if (onSendScore != null)
        {
            if (!scoreSent)
            {
                scoreSent = true;
                onSendScore(score);
            }
        }
    }
    









}
