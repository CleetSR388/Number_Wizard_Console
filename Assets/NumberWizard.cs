using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start ()
    {
        StartGame();
	}

    void StartGame()
    {

        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to number wizard!");
        Debug.Log(" Choose your number...I will gues it!");
        Debug.Log(" Highest number is:" + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Tell me if your number is igher or lower then 500");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();

        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genius!");
            StartGame();

        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower then..." + guess);
    }

}
