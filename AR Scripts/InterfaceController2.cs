using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceController2 : MonoBehaviour
{
    bool isOnGallery = false;
    bool isOnColorized = false;

    [SerializeField] GameObject GalleryPanel;
    [SerializeField] GameObject ColorizedImage;
    [SerializeField] GameObject OriginalButton;
    [SerializeField] GameObject ColorizeButton;

    public void toggleGalleryPanel()
    {
        if(isOnGallery)
        {
            GalleryPanel.SetActive(false);
            isOnGallery = false;
        }
        else
        {
            GalleryPanel.SetActive(true);
            isOnGallery = true;
        }
    }

    public void toggleColorizedImage()
    {
        if(isOnColorized)
        {
            ColorizedImage.SetActive(false);
            OriginalButton.SetActive(false);
            ColorizeButton.SetActive(true);
            isOnColorized = false;
        }
        else
        {
            ColorizedImage.SetActive(true);
            OriginalButton.SetActive(true);
            ColorizeButton.SetActive(false);
            isOnColorized = true;
        }
    }
}
