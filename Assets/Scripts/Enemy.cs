using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	private Collider _collider;
	// Use this for initialization
	void Start () {
		_collider = this.GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
		if(FoveInterface.IsLookingAtCollider(_collider)) {
			this.gameObject.SetActive(false);
		}
	}
}
