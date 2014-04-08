using UnityEngine;
using System.Collections;

public class HighScoreNameDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<TextMesh>().text=HighScoreTemp.permanentHighScoreName;
	}
}
