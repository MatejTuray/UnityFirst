using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public PlayerCollision player;
    public Text text;

    // Update is called once per frame
    void FixedUpdate()
    {
        text.text = player.Score.ToString();
    }
}
