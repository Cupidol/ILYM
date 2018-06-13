using UnityEngine;
using System.Collections;

public class interaction_indicator_collider_inner : MonoBehaviour
{
	public Collider innercollider;
	public GameObject billboard_dot;
	public GameObject billboard_e;


	void OnTriggerEnter(Collider innercollider)
	{
		billboard_dot.SetActive (false);
		billboard_e.SetActive (true);
		Debug.Log ("inner enter");
	}
	void OnTriggerExit(Collider innercollider)
	{
		billboard_e.SetActive (false);
		billboard_dot.SetActive (true);
		Debug.Log ("inner exit");
	}

}