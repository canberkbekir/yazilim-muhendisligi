﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

	
	void OnTriggerEnter(Collider other){
		if(other.CompareTag("Rooms"))
		{
			Destroy(other.gameObject);
		}
		
	}
}
