using UnityEngine;
using System.Collections;

public class EnterName : MonoBehaviour {
	void OnMouseEnter()
	{
		renderer.material.color = Color.red;
	}
	
	void OnMouseExit()
	{
		renderer.material.color = Color.yellow;	
	}

	void OnMouseUp()
	{
		string name  = new string(NamePrint.characterList);
		HighScoreTemp.permanentHighScoreName = name;
		HighScoreTemp.permanentHighScore = GUIControllerFireEmblem.highScorePDF;
		GUIControllerFireEmblem.highScorePDF = 0;
		Application.LoadLevel("startScreen");
	}
}