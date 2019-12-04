using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class TextInit : MonoBehaviour
{
    public Text dialogue;

    public string blank;

    // Start is called before the first frame update
    void Start()
    {
        dialogue = GetComponent<Text>();
        dialogue.text = " ";

    }
    // Update is called once per frame
    
    public void PickUpCall() //call when player clicks "pick up call" button
    {
        dialogue.text = "Tyria: Thank god you finally picked up. \n Where the hell are you?"; //first text to appear on screen
    }

    public void OutForADrive() //call if player clicks "out for a drive" button
    {

    }

    public void DumpingTheBody() //call if player clicks "dumping the body" button
    {

    }
}
