using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PuzzlePieces;

public class PuzzlePieces : MonoBehaviour
{

    public enum PuzzleID { Yellow = 1, Orange = 2, Red = 3, Blue = 4, Purple = 5, TheTrow = 6 }
    public PuzzleID puzzleID;
    public Material puzzleMaterial;
    public MeshRenderer meshRenderer;
    public string type = "empty";
    /////public Item thisKey = new Item();
    
    // Start is called before the first frame update
    void Start()
    {
              
        meshRenderer.material = puzzleMaterial;
        // itemID is set to the puzzleID number
        ////thisKey.itemID = (int)puzzleID;
        // SetMaterial(puzzleID);
        switch(puzzleID)
        {       
            case PuzzleID.Yellow:
                {
                    name = type + " Yellow";
                    meshRenderer.material.color = new Color((225f/225f), (200f/225f), (0f/225f));
                    break;
                }
            case PuzzleID.Orange:
                {
                    name = type + " Orange";
                    meshRenderer.material.color = new Color((225f / 225f), (111f / 225f), (0f / 225f));
                    break;
                }
            case PuzzleID.Red:
                {
                    name = type + " Red";
                    meshRenderer.material.color = new Color((139f/225f),0f,0f);
                    break;
                }
            case PuzzleID.Blue:
                {
                    name = type + " Blue";
                    meshRenderer.material.color = new Color((0f / 225f), (111f / 225f), (200f / 225f));
                    break;
                }
            case PuzzleID.Purple:
                {
                    name = type + " Purple";
                    meshRenderer.material.color = new Color((150f / 225f), (0f / 225f), (255f / 225f));
                    break;
                }               
            case PuzzleID.TheTrow:
                {          
                    name = type;
                    meshRenderer.material.color = new Color((80f / 225f), (82f / 225f), (80f / 225f));
                    break;
                }       
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
