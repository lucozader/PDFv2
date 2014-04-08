using UnityEngine;
using System.Collections;

public class ConvertMouse : MonoBehaviour {
	public static float xtest;
	public static float ytest;
	public RaycastHit hit; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = camera.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray,out hit)){
			xtest = hit.collider.transform.position.x;
			ytest = hit.collider.transform.position.y;

		}

	}
}
