﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ShipSmoothMove : MonoBehaviour {
	public float heightOffset = -450;
	public Vector3 velocity = Vector3.zero;
	public Vector3 force = Vector3.zero;
	
	public float maxSpeed = 200.0f;
	public float mass = 1.0f;
	bool oncerrr= true;
	bool oncerrrr=true;
	
	public GameObject[] pathPoints;
	
	int targetNum = 0;
	
	// Use this for initialization
	void Start () {
		//pathPoints = inputPathPoints;
	
	
		//transform.Rotate(270, 180, 0);

		maxSpeed = 200.0f;
		mass = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0; i<pathPoints.Length;i++){
			Vector3 victor = new Vector3(pathPoints[i].transform.position.x,heightOffset,pathPoints[i].transform.position.z);
			pathPoints[i].transform.position = victor;}

		//if (pathToUse == 1)
		force += FollowPath(pathPoints);
		//if (pathToUse == 2)
		//force += FollowPath(path2);
		
		Vector3 acceleration = force / mass;
		
		velocity += acceleration * Time.deltaTime;
		transform.position += velocity * Time.deltaTime;
		
		force = Vector3.zero;
		
		if (velocity.magnitude > float.Epsilon)
		{
			transform.forward = Vector3.Normalize(velocity) ;
		}
	}
	
	Vector3 Seek(Vector3 target)
	{
		Vector3 desired = target - transform.position;
		desired.Normalize ();
		desired *= maxSpeed;
		
		return desired - velocity;
	}
	
	Vector3 FollowPath(GameObject[] path)
	{
		Vector3 desired = path[targetNum].transform.position - transform.position;
		
		if(desired.magnitude < 20.0f)
		{
			targetNum++;
			if(targetNum == path.Length)
			{
				targetNum = 0;////maby destroy gameobject here and update value
			}
		}
		
		desired.Normalize ();
		desired *= maxSpeed;
		
		return desired - velocity;
	}
	void SetPathPoints(GameObject[] inputPathPoints)
	{
	if(oncerrr ==true){
			pathPoints = inputPathPoints;
			oncerrr = false;}

		

	
	}}
