using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour 
{
	void OnTriggerEnter(Collider hit)
	{
		if (hit.CompareTag("Player"))
		{
			this.transform.parent = hit.gameObject.transform;
		}
	}
}