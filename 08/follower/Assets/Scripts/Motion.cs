using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
	}

	public Transform[] objects;
	// Update is called once per frame
	void Update ()
	{
		int minimalRangeNumber=0;
		float minimalRange = Vector3.Distance (objects [0].position, transform.position);
		for (int i = 1; i < objects.Length; i++) {
			float range = Vector3.Distance (objects [i].position, transform.position);
			if (minimalRange > range) {
				minimalRange = range;
				minimalRangeNumber = i;

			}
		}
		Vector3 direction = objects [minimalRangeNumber].position - transform.position;
		direction.Normalize();
		transform.Translate (direction * Time.deltaTime * 1);
	}
}
