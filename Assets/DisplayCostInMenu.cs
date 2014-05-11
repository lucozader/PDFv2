using UnityEngine;
using System.Collections;

public class DisplayCostInMenu : MonoBehaviour {
	public string condition;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject myCube = GameObject.Find("UICamera");
		TowerSelector temp =  myCube.GetComponent<TowerSelector>();
		if( gameObject.tag == "RapidFireCost"){
		GetComponent<TextMesh>().text =  temp.towerCosts[2].ToString();
		}
		if( gameObject.tag == "CannonFireCost"){
			GetComponent<TextMesh>().text =  temp.towerCosts[0].ToString();
		}
		if( gameObject.tag == "MortarFireCost"){
			GetComponent<TextMesh>().text =  temp.towerCosts[3].ToString();
		}
		if( gameObject.tag == "SlowFireCost"){
			GetComponent<TextMesh>().text =  temp.towerCosts[1].ToString();
		}
	}
}
