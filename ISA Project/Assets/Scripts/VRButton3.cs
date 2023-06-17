using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VRButton3 : MonoBehaviour
{
    private void OnMouseUpAsButton()
    {
        SceneManager.LoadScene("MainMenu3");
    }
}
