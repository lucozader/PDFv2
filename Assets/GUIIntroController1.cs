using UnityEngine;
using System.Collections;

public class GUIIntroController1 : MonoBehaviour {
	public GameObject scroll;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		Vector3 victorrr = new Vector3(0.5f,-0.2f,0f);
			GUI.depth=0;
			GameObject scroll3 = Instantiate(scroll,victorrr, Quaternion.identity)as GameObject;
	}
}
