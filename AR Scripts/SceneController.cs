using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    // Function to load main menu scene
    public void MainMenu() 
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Function to load image scene
    public void ImageScene()
    {
        SceneManager.LoadScene("ImageScene");
    }

    // Function to load object scene
    public void ObjectScene()
    {
        SceneManager.LoadScene("ObjectScene");
    }
}
