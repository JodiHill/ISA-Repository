using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VRButton2 : MonoBehaviour
{
    private void OnMouseUpAsButton()
    {
        SceneManager.LoadScene("MainMenu2");
    }
}
