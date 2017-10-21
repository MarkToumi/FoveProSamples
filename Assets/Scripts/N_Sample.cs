using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N_Sample : MonoBehaviour {
	private float origin;
	private float per;
	private float result;
	// Use this for initialization
	void Start () {
		origin = 100f;
		per = 0.8f;
		result = 0.0f;
		Magouke ();
	}

	void Magouke() {
		for (int i = 0; i < 10; i++) {
			result = origin * per;
			Debug.Log (result);
			origin = result;
		}
	}
}
