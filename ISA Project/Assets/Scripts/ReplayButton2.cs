using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayButton2 : MonoBehaviour
{
    
    public void ReplayGame()
    {
        SceneManager.LoadScene("Level 2");
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
