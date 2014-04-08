using UnityEngine;
using System.Collections;

public class NamePrint : MonoBehaviour {
	public static char [] characterList = new char[20];
	//public static int [] characterScore = new int[20];
	public static int count = 0;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		printOutName();
	}

	void printOutName(){
		string name  = new string(characterList);
		GetComponent<TextMesh>().text =  name;
	}
}
