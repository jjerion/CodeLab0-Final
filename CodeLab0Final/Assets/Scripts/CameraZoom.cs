using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    
    public void Zoom()
    {
        if (Camera.main.fieldOfView >= 53)
        { 
            InvokeRepeating("IncreaseZoom", 2, 5); //call IncreaseZoom every 5 seconds

        }   
    }
 
    public void IncreaseZoom()
    {
        Camera.main.fieldOfView -= 1; //reduce fieldOfView by 1 (results in rough zoom (not smooth))
    }
}
