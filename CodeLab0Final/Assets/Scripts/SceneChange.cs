
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //change to the end screen
    public void ChangeScene()
    {
        SceneManager.LoadScene("EndScreen"); 
    }
}
