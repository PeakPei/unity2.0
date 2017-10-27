using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Terminal.WriteLine("Hack the system! Follow the real world hackers or go for the challenge round.");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for Equifax");
        Terminal.WriteLine("Press 2 for Yahoo");
        Terminal.WriteLine("Press 3 for Pentagon");
        Terminal.WriteLine("Enter your choice here:");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
