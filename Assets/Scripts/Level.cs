using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] float delayInSecounds = 3f;

    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        StartCoroutine(WaitAndLoadGame());
        FindObjectOfType<GameSession>().ResetGame();
    }

    IEnumerator WaitAndLoadGame()
    {
        yield return new WaitForSeconds(delayInSecounds);
        SceneManager.LoadScene(1);
    }

    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoadGameOver()); 
    }

    IEnumerator WaitAndLoadGameOver()
    {
        yield return new WaitForSeconds(delayInSecounds);
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
