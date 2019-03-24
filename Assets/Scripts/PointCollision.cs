using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollision : MonoBehaviour
{
    private PlayerCollision pcoll;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Pl")
        {
            Debug.Log("score");
            PointCollision.Destroy(GetComponent("Capsule"));
        }
    }
}
