using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public Vector3 playerSpawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        //create Player at set location Vector3(-30,0.119345188,30.6000004)
        Instantiate(playerPrefab, playerSpawnLocation,Quaternion.identity);
        //send player to location in portal room

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    public void GreenZone()
    {
        //yellow key visable above purple lock
        //purple Lock isLocked
        //yellow Lock is Locked
        //Red lock is locked
    }
    public void YellowZone()
    { }
    public void OrangeZone()
    { }
    public void RedZone()
    {
        //create enemeys(weeds) *6
    }
    public void BlueZone()
    {
        //create enemy(Crab) at Vector3(-30,0.119345188,30.6000004)
    }
    public void PurpleZone()
    { }
}
