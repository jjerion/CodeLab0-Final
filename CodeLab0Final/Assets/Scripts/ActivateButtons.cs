using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class ActivateButtons : MonoBehaviour
{
    //button vars to use in inspector (drag and drop ui buttons to empty field)
    public Button pickUp;
    public Button outForADrive;
    public Button dumpingTheBody;
    public Button wellThatsNew;
    public Button fuckTheCops;
    public Button badIdea;
    public Button youreRight;
    public Button hangUp;


    public void ActivatePickUp() //called one at a time (probably inefficient method but easy for me to organize)
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

    public void ActivateWellThatsNew()
    {
        wellThatsNew.gameObject.SetActive(true);
    }
    public void DeActivateWellThatsNew()
    {
        wellThatsNew.gameObject.SetActive(false);
    }

    public void ActivateFuckTheCops()
    {
        fuckTheCops.gameObject.SetActive(true);
    }
    public void DeActivateFuckTheCops()
    {
        fuckTheCops.gameObject.SetActive(false);
    }

    public void ActivateBadIdea()
    {
        badIdea.gameObject.SetActive(true);
    }
    public void DeActivateBadIdea()
    {
        badIdea.gameObject.SetActive(false);
    }

    public void ActivateYoureRight()
    {
        youreRight.gameObject.SetActive(true);
    }
    public void DeActivateYoureRight()
    {
        youreRight.gameObject.SetActive(false);
    }

    public void ActivateHangUp()
    {
        hangUp.gameObject.SetActive(true);
    }
    public void DeActivateHangUp()
    {
        hangUp.gameObject.SetActive(false);
    }
}
