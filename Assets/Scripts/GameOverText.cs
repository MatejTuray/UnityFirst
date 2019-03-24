
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class GameOverText : MonoBehaviour
{

    public PlayerControl player;
    public Text text;

   


    // Update is called once per frame
    void FixedUpdate()
    {
       
        if (!player.enabled)
        {
            text.text = "GAME OVER!";
            text.fontSize = 200;
            
            
          
        }
    }
}
