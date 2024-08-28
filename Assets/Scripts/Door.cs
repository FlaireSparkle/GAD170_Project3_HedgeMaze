using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static PuzzlePieces;

public class Door : MonoBehaviour
{
    public int portalLocation = 0;
    public bool portalActivated = false;
    // link to door object

    
    public void Start()
    {
        portalActivated = false;
        //get door's boxcollider
       // Collider door = GetComponent<Collider>();
        //name = (ToString(GetComponent(PuzzlePieces.puzzleID))) + " Doorway";
    }
    public void Update()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.transform.GetComponent<Player>())&&(portalActivated == true))
        {
            SceneManager.LoadScene(portalLocation);
        }
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
        portalActivated = true;
        //make door visable

    }
    public void ClosePortal()
    {
        //set door to intangable 

        //deactivate portal
        portalActivated = false;
    }
    public void UsePortal()
    {

    }


}
