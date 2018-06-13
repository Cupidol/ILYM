using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction_indicator_collider_outer: MonoBehaviour {

	public Collider outercollider;
	public GameObject billboard_dot;

	void OnTriggerEnter(Collider outercollider)
	{
		billboard_dot.SetActive (true);
		Debug.Log ("outer enter");
	}
	void OnTriggerExit(Collider outercollider)
	{
		billboard_dot.SetActive (false);
	}
}
