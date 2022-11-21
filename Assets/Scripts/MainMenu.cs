using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenCredit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created By Luqman Kurniawan");
    }
}