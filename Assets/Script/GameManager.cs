using UnityEngine;
using System.Collections;

using System.Collections.Generic;        //Allows us to use Lists. 
using Completed;

public class GameManager : MonoBehaviour
{

   // public static GameManager instance = null;                //Static instance of GameManager which allows it to be accessed by any other script.
   public BoardManager boardScript;                        //Store a reference to our BoardManager which will set up the level.
    private int level = 3;                                    //Current level number, expressed in game as "Day 1".

    //Awake is always called before any Start functions
    void Awake()
    {
        boardScript = GetComponent<BoardManager>();

        //Call the InitGame function to initialize the first level 
        InitGame();
    }

    //Initializes the game for each level.
    void InitGame()
    {
        //Call the SetupScene function of the BoardManager script, pass it current level number.
        boardScript.SetupScene(level);

    }



    //Update is called every frame.
    void Update()
    {

    }
    
}