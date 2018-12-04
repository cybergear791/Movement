using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer3 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		Renderer rend = GetComponent<Renderer>();
		StartCoroutine (TriggerTheLight (rend));

	}
	

	IEnumerator TriggerTheLight(Renderer rend)
	{
		rend.material.color = Color.red;
		yield return new WaitForSeconds(.05f);
		rend.material.color = Color.blue;
		yield return new WaitForSeconds(.05f);
		rend.material.color = Color.green;
		yield return new WaitForSeconds(.05f);
		rend.material.color = Color.yellow;
		StartCoroutine (TriggerTheLight (rend));

	}
}
