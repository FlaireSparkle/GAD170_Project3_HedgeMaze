using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Stats //: MonoBehaviour
{
    /// <summary>
    /// This is the stats data for every character (both players and enemys) in the game!!
    /// Class, Level, maxHealth, Attack, Defence  
    /// </summary>
    string[] statsData = (("Class,Level,Health,Attack,Defence\nPlayer,1,10,4,1\nPlayer,2,16,6,4\nWeed,1,5,2,0\nWeed,2,6,3,1\nCrab,1,20,4,1\nCrab,2,26,6,4\nRoseBush,0,1,0,0").Split(new string[] { ",", "\n" }, System.StringSplitOptions.None));
    /* "Class,Level,Health,Attack,Defence
       Player,1,10,4,1
       Player,2,16,6,4
       Weed,1,5,2,0
       Weed,2,6,3,1
       Crab,1,20,4,1
       Crab,2,26,6,4
       RoseBush,0,1,0,0"
    */

    //creates these stats for a class using the characterClass and myLevel
    public int maxHealth;
    public int attack;
    public int defence;


    /// <summary>
    /// sets maxHealth, Attack and Defence stats for a class using the "characterClass" and "myLevel"
    /// </summary>
    public void SetStats(string Class, int Level)
    {
        //change Level int to string
        string LevelString = Level.ToString();
        for (int i = 0; i < statsData.Length; i++)
        {
            //if the class and myLevel match that in the array
            if ((Class.ToLower() == statsData[i].ToLower()) && (LevelString == statsData[i + 1]))
              {
                //set the stats    int.Parse() turns the srting inside the brackets into an int
                maxHealth = int.Parse(statsData[i + 2]);
                attack = int.Parse(statsData[i + 3]);
                defence = int.Parse(statsData[i + 4]);
                return;
            }
        }
    }
}
