using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{

    public GameManager gm;
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Pl")
        {
            Debug.Log("Game Should end");
            gm.NextLevel();
        }
    }
}
