using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAudio : MonoBehaviour
{

    void Start()
    {
        Debug.Log(gameObject);
        if (gameObject != null)
        {
            BGSound.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
