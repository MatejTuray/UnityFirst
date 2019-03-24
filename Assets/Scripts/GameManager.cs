using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameOver = false;
    public bool restart = false;
    public bool nextLevel = false;
    public GameObject endLevelUi;
    public void EndGame()
    {
        if (!gameOver)
        {
            gameOver = true;
            Invoke("Restart", 5);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void NextLevel()
    {
        if (!nextLevel)
        {
            nextLevel = true;
            Debug.Log("Should load animation and next level");
            endLevelUi.SetActive(true);
        }
    }
}
