using UnityEngine;
using System.Collections;

public class RangeUpgrade : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnMouseExit () {
		//Vector3 victor = new Vector3(ConvertMouse.xtest,ConvertMouse.ytest,2000);
		//	transform.position = victor;
		GUIControllerFireEmblem.ranger=2;

	}
}
