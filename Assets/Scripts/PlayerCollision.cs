using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerControl player;
    public Transform pl;
    private int score = 0;

    public int Score { get => score; set => score = value; }

    private void FixedUpdate()
    {
        if (pl.position.y < -1f)
        {
            player.enabled = false;
           
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
           
            player.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
       
     
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Point")
        {
            
            Score++;       
            Destroy(other.gameObject);
        }
    }
}

