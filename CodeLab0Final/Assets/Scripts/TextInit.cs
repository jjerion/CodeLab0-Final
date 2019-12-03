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
    void Update()
    {
        
    }
}
