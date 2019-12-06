using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class TextInit : MonoBehaviour
{
    public Text dialogue;

    // Start is called before the first frame update
    void Start()
    {
        dialogue = GetComponent<Text>();
        dialogue.text = " "; //set var to text component, then erase pre-existing text

    }
    
    public void PickUpCall() //call when player clicks "pick up call" button
    {
        dialogue.text = "Tyria: Thank god you finally picked up. Where the hell are you?"; //first text to appear on screen
    }

    public void OutForADrive() //call if player clicks "out for a drive" button
    {
        dialogue.text = "Tyria: You need to be careful. Some cops came by the hotel today asking about my girlfriend. Don't worry, my shift ended about an hour before they got there.";
    }

    public void DumpingTheBody() //call if player clicks "dumping the body" button, etc
    {
        dialogue.text = "Tyria: What the fuck, Aileen. You can't say shit like that on the phone -- especially not now. There were cops at the hotel today asking about you. Don't worry, my shift ended about an hour before they got there.";
    }

    public void WellThatsNew()
    {
        dialogue.text = "Tyria: I know. They've never done this before. I know you don't want to hear this, but we need to go home and lay low for a while.";
    }

    public void FuckTheCops()
    {
        dialogue.text = "Tyria: This is serious. If we don't play this right, something bad could happen. You need to come home so we can get our story straight.";
    }

    public void BadIdea()
    {
        dialogue.text = "Tyria: I can't argue with you right now. Call me when you come to your senses, after you've taken care of it. And stay safe.";
    }

    public void YoureRight()
    {
        dialogue.text = "Tyria: I'll see you at home, Aileen. Be safe.";
    }
}
