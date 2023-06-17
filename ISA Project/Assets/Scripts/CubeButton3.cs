using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeButton3 : MonoBehaviour
{
    private void OnMouseUpAsButton()
    {
        SceneManager.LoadScene("MainMenuTest3");
    }
}
