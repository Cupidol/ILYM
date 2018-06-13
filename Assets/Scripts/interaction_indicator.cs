using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction_indicator : MonoBehaviour {

	public Sprite billboard_button, billboard_indicator, billboard_hider;
	public GameObject player;
	public GameObject goal;
	private float distance;
	private int tutorial_count;


	void Start () {
		player = GameObject.FindWithTag("Player");
	}
	void Update ()
	{
		distance = Vector3.Distance (player.transform.position, goal.transform.position);
		if (distance <= 3f) {
			GetComponent<SpriteRenderer> ().sprite = billboard_button;
		} else {
			GetComponent<SpriteRenderer> ().sprite = billboard_indicator;
		}
		if (distance <= 2f) {
			GetComponent<SpriteRenderer> ().sprite = billboard_hider;
		}
	}
}