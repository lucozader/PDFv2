using UnityEngine;
using System.Collections;

public class timerskull : MonoBehaviour {
	float timer = 0;
//	public AudioClip startSound;

	// Use this for initialization
	void Start () {
		//audio.PlayOneShot(startSound);

	}
	
	// Update is called once per frame
	void Update () {
		timer  = timer + 1*Time.deltaTime;
		if(timer > 5&&GUIControllerFireEmblem.highScorePDF>HighScoreTemp.permanentHighScore){
			Application.LoadLevel ("HighScoreEntryScreen");}
		if(timer > 5&&GUIControllerFireEmblem.highScorePDF<HighScoreTemp.permanentHighScore){

		Application.LoadLevel("startScreen");}

	}
}
