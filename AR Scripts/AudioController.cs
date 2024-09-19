using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] GameObject PlayButton;
    [SerializeField] GameObject StopButton;

    // Function to activate play button and deactivate stop button
    public void toggleButtonPlay()
    {
        PlayButton.SetActive(true);
        StopButton.SetActive(false);
    }

    // Function to activate stop button and deactivate play button
    public void toggleButtonStop()
    {
        PlayButton.SetActive(false);
        StopButton.SetActive(true);
    }
}
