using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool endGame = false;
    public void EndGame()
    {
        if (endGame)
        {
            return;        
        }

        endGame = true;
        StartCoroutine("PlayEndGameAnimation");
    }

    IEnumerator PlayEndGameAnimation()
    {   
        yield return new WaitForSeconds(3f);

        Debug.Log("GAME OVER");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
