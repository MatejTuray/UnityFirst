using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadScore : MonoBehaviour
{
    public PlayerCollision pc;
    public Text text;
    public int score;
    private void FixedUpdate()
    {
        score = pc.Score;
        text.text = $"YOUR SCORE: {score.ToString()} ";
    }
}
