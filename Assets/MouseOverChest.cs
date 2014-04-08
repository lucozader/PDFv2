using UnityEngine;
using System.Collections;

public class MouseOverChest : MonoBehaviour {

	bool once = false;
	 float timer = 0;

	void Update(){
	
		timer = timer+1*Time.deltaTime;
			if(timer > 3){Destroy (gameObject);}



			
			

			

	}

		void OnMouseEnter()
		{
			//move treasure chest to money and increase money by 100
			if(once == false){
			EnergyManager.energy += 100;
			GUIControllerFireEmblem.highScorePDF = GUIControllerFireEmblem.highScorePDF+1000;
			Debug.Log("MOUSE ENTERED");

			PlaySoundsAfterDestroy.MoneySoundOnce = true;
			once = true;
			TextFixRotation.death = true;
			Destroy (gameObject);}
			
		}

	}

