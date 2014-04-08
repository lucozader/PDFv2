using UnityEngine;
using System.Collections;

public class DrawRangeCircle : MonoBehaviour {
	public GameObject rangeIndicator;
	void OnMouseEnter(){
		GameObject rangeFinder = Instantiate(rangeIndicator, transform.position, Quaternion.identity) as GameObject;
	}

}
