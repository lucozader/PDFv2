using UnityEngine;
using System.Collections;

public class RangePlaneTest : MonoBehaviour {
	public GameObject rangeIndicator;
	void OnMouseEnter(){
		GameObject rangeFinder = Instantiate(rangeIndicator, transform.position, Quaternion.identity) as GameObject;
	}
	
}
