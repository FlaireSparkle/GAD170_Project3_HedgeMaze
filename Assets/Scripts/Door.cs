using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PuzzlePieces;

public class Door : MonoBehaviour
{

    private bool portalActivated = false;
    // link to door object
    
    public void Start()
    {
        //name = (ToString(GetComponent(PuzzlePieces.puzzleID))) + " Doorway";
    }
    public void Update()
    {
        //if ((portalActivated==true)&&())
        //{ }
    }

    public void OpenDoor()
    {
        //translate door down (or disable door)
    }
   
    public void CloseDoor()
    {
        //translate door up
    }
    public void OpenPortal()
    { 
        //activate portal
        //make door visable
    }
    public void ClosePortal()
    {
         //set door to intangable 
         //deactivate portal
    }
    public void UsePortal()
    {

    }

}
