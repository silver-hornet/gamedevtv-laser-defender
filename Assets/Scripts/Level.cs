using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] float delayInSeconds = 2;

    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0); //using a scene index to load the scene, which is better than using a string reference
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game"); //using a string reference to load the scene
    }

    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad());
        
    }

    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene("Game Over");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
