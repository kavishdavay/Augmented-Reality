using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerController : MonoBehaviour
{

    [SerializeField] GameObject InfoPanel;
    [SerializeField] GameObject MarkerBtn;

    public void togglePanel()
    {
        InfoPanel.SetActive(true);
        MarkerBtn.SetActive(false);
    }

    public void closePanel()
    {
        InfoPanel.SetActive(false);
        MarkerBtn.SetActive(true);
    }
}
