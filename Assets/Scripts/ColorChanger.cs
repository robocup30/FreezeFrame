﻿using UnityEngine;
using System.Collections;

public class ColorChanger : MonoBehaviour {

	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			other.gameObject.GetComponent<SpriteRenderer>().color = this.particleSystem.startColor;
		}
	}
}
