using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
   

    public Rigidbody rb = new Rigidbody();
    public float forceF = 500f;   
    public float forceL = -20f;
    public float forceR = 20f;
    public float jump = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forceF * Time.deltaTime);
        if (Input.GetKey("a"))
        {
            rb.AddForce(forceL, 0 , 0 * Time.deltaTime, ForceMode.VelocityChange);
        };
        if (Input.GetKey("d"))
        {
            rb.AddForce(forceR, 0, 0 * Time.deltaTime, ForceMode.VelocityChange);
        };
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, jump, 0 * Time.deltaTime, ForceMode.VelocityChange);
        };
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
