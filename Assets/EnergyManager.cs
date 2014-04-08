using UnityEngine;
using System.Collections;

public class EnergyManager : MonoBehaviour
{
	public int initialEnergy = 1000;
	public GameObject energyDisplay;
	
	public static float energy;

	// Use this for initialization
	void Start ()
	{
		energy = initialEnergy;
	}
	
	void Update()
	{
		energyDisplay.GetComponent<TextMesh>().text = energy.ToString();
	}
}
