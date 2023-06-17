using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAudio : MonoBehaviour
{

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject);
        if (gameObject.tag == "Music")
        {
            BGSound.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }
    }
}
