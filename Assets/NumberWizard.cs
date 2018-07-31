using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        int max = 1000;
        int low = 1;
        int guess = 500;



        Debug.Log("Welcome to number wizard!");
        Debug.Log(" Choose your number...I will gues it!");
        Debug.Log(" Higher number is:" + max);
        Debug.Log("Lowest number is: " + low);
        Debug.Log("Tell me if your number is igher or lower then 500");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            min = guess;
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed.");
        }
    }
}
