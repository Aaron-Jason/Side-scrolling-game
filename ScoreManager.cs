using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [Header("UI")]
    public int tottalScore;
    public TextMeshProUGUI scoreTxt;

    public void AddScore(int score)
    {
        tottalScore += score;
        scoreTxt.text = "Score: " + tottalScore.ToString();
    }
    public void MinusScore(int score)
    {
        tottalScore += score;
        scoreTxt.text = "Score: " + tottalScore.ToString();
    }
}
