using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleInfoPanel : MonoBehaviour
{

    [SerializeField] GameObject InformationPanel;
    [SerializeField] GameObject MuteButton;
    [SerializeField] GameObject PlayButton;

    // Function to activate info panel
    public void ActivatePanel() 
    {
        InformationPanel.SetActive(true);
    }

    // Function to close info panel
    public void ClosePanel() 
    {
        InformationPanel.SetActive(false);
        MuteButton.SetActive(false);
        PlayButton.SetActive(true);
    }
}
