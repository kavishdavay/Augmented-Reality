using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatable : MonoBehaviour
{
    public bool isActive = true;
    public GameObject rotateObj;

    // Update is called once per frame
    void Update()
    {
        // Checks if object is active
        if (isActive)
        {
            // Checks if touch is registered
            if (Input.touchCount == 1)
            {
                // Get touch distance on x-axis, calculate angle of rotation and rotate object
                Touch screenTouch = Input.GetTouch(0);

                if (screenTouch.phase == TouchPhase.Moved)
                {
                    rotateObj.transform.Rotate(0f, -screenTouch.deltaPosition.x, 0f);
                }

            }
        }
    }
}