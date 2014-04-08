using UnityEngine;
using System.Collections;

public class QuitTextScript : MonoBehaviour {
	
	//public AudioClip quitSound;

	 void OnMouseEnter()
	{
		renderer.material.color = Color.yellow;
		//Debug.Log("MOUSE ENTERED");
	}
	
	 void OnMouseExit()
	{
		renderer.material.color = Color.red;

	}
	
	void OnMouseUp()
	{
		//audio.PlayOneShot(quitSound);
		Application.Quit();
		
	}

}
