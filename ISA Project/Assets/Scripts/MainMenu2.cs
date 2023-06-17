using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu2 : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("ISA2");
    }

    public void Manual()
    {
        SceneManager.LoadScene("Manual");
    }
}
