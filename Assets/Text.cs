using UnityEngine;
using System.Collections;

public class Text : MonoBehaviour {
	
	public GameObject textTimer;
	
	// Use this for initialization
	void Start () {
		Instantiate(textTimer,transform.position + Vector3.up*10f -Vector3.right*2f,transform.rotation);
		TextMesh tm = textTimer.GetComponent<TextMesh>();
		tm.text = transform.name;
		
	}
	// Update is called once per frame
	void Update () {
		
	}
}
