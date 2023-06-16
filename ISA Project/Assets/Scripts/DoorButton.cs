using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorButton : MonoBehaviour
{
    private void OnMouseUpAsButton()
    {
        SceneManager.LoadScene("GameOver2");
    }
}
