using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VRButton: MonoBehaviour
{
    private void OnMouseUpAsButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
