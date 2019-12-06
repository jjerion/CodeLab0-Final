using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class DestroyStart : MonoBehaviour
{
    public GameObject startButton;
    


    public void DestroyStartButton() //erase start button when clicked (alternative to ActivateButton script)
    {
        startButton = GameObject.FindGameObjectWithTag("Start");

        Destroy(startButton);
    }
}
