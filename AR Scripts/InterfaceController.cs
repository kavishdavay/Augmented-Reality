using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceController : MonoBehaviour
{

    // Initialise checks
    bool isOnVideo = false;
    bool isOnStatue = false;

    [SerializeField] GameObject VideoPanel;
    [SerializeField] GameObject StatueObject;

    // Function to activate or deactivate video panel
    public void toggleVideoPanel()
    {
        if(isOnVideo)
        {
            VideoPanel.SetActive(false);
            isOnVideo = false;
        }
        else
        {
            VideoPanel.SetActive(true);
            isOnVideo = true;
        }
    }

    // Function to toggle statue object
    public void toggleStatue()
    {
        if(isOnStatue)
        {
            StatueObject.SetActive(false);
            isOnStatue = false;
        }
        else
        {
            StatueObject.SetActive(true);
            isOnStatue = true;
        }
    }
}
