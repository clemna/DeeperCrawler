using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public Canvas credits;

    public void StartGame()
    {
        SceneManager.LoadScene("LVL 1");
    }

    public void Credits()
    {
        credits.enabled = true;
    }

    public void CreditsBackButton()
    {
        credits.enabled = false;
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("WYSZED£EM KURWA");
    }
}

