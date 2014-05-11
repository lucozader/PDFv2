using UnityEngine;
using System.Collections;

public class DisplayRemainingShipHealth : MonoBehaviour {
	int healthDisplay;
	public GameObject textDisplay;
	bool once = false;
	public  bool destroy = false;
	GameObject pro;
	// Use this for initialization
	void Start () {
		Vector3 pro1 = new Vector3();
		pro = Instantiate (textDisplay,transform.position,Quaternion.identity)as GameObject;


	}
	
	// Update is called once per frame
	void Update () {if(destroy == true){
			Destroy(pro);
		}

		SmallEnemy scriptInstance = gameObject.GetComponent<SmallEnemy>();

		if(destroy==false){
			pro.transform.position = transform.position;}
	//	if(scriptInstance.health<=0){Destroy(pro);}

		healthDisplay = (int)scriptInstance.health;
		pro.GetComponent<TextMesh>().text =  healthDisplay.ToString();



		//display for 2 seconds if hit by bullet//5 second cool off
		//green //yellow // red
	
	}
}
