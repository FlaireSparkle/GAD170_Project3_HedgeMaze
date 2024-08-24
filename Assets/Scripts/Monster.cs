using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public string myClass = "Weed";
    public int myLevel = 1;
    public Stats myStats = new Stats();
    //public bool isCrab = false;
    private int currentHealth = 0;

    public Material weedMaterial;
    public Material crabMaterial;
    public MeshRenderer meshRenderer;

    public enum MonsterClass {Weed,Crab};
    public MonsterClass monsterClass;
    // Start is called before the first frame update
    void Start()
    {
        StatCreation();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    public void StatCreation()
    {
        switch (monsterClass)
        {
            case MonsterClass.Weed:
            { 
                meshRenderer.material = weedMaterial;
                //set material to randomcolour
                meshRenderer.material.color = new Color(Random.Range(0.25f, 1f), Random.Range(0.25f, 0.8f), Random.Range(0f, 0.75f));
                break; 
            }
            case MonsterClass.Crab:
            { 
                myClass = "Crab";
                meshRenderer.material = crabMaterial;
                break; 
            }
        }         
        //change object name to match class
        name = myClass;
        myStats.SetStats(myClass, myLevel);
       
    }
    
        
        
     
}