using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class ActivateButtons : MonoBehaviour
{
    public Button pickUp;
    public Button outForADrive;
    public Button dumpingTheBody;
    public void ActivatePickUp()
    {  
        pickUp.gameObject.SetActive(true);
    }

    public void DeActivatePickUp()
    {
        pickUp.gameObject.SetActive(false);
    }

    public void ActivateOutForADrive()
    {
        outForADrive.gameObject.SetActive(true);
    }
    public void DeActivateOutForADrive()
    {
        outForADrive.gameObject.SetActive(false);
    }

    public void ActivateDumpingTheBody()
    {
        dumpingTheBody.gameObject.SetActive(true);
    }
    public void DeActivateDumpingTheBody()
    {
        dumpingTheBody.gameObject.SetActive(false);
    }
}
