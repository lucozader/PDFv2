using UnityEngine;
using System.Collections;

public class RestoreSpeed : MonoBehaviour {
	
	public float originalSpeed;
	public float time;

	// Use this for initialization
	void Start ()
	{
		Invoke("RestoreSpeedFunction", time);
	}
	
	void RestoreSpeedFunction()
	{
		ShipSmoothMove scriptInstance = gameObject.transform.parent.GetComponent<ShipSmoothMove>();
		scriptInstance.maxSpeed = originalSpeed;
		Destroy(gameObject);
	}
}
