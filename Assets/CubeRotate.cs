using UnityEngine;
using System.Collections;

public class CubeRotate : MonoBehaviour {
	public int rotateRate = 40;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,rotateRate*Time.deltaTime,0);

	}
}
