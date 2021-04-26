using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public Canvas credits;
    public Canvas pause;

    public void StartGame()
    {
        SceneManager.LoadScene("LVL 1");
        Cursor.lockState = CursorLockMode.Locked;
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

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause.enabled = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void PauseReturnToMenuButton()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void PauseBackButton()
    {
        pause.enabled = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}

