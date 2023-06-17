using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayButton : MonoBehaviour
{
    
    public void ReplayGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("ISA2");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
