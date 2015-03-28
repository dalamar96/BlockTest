using UnityEngine;
using System.Collections;

public class BrickScript : MonoBehaviour {

	private bool isDying = false;
	void onStart() {

	}

	void FixedUpdate() {

	}

	void OnCollisionEnter(Collision collision) 
	{
		if ((collision.gameObject.tag == "Shot") && !isDying) {
			Destroy (this.gameObject, 1.0f);
			GameController2.scoreValue += 1;
			isDying = true;
		}
	}
}
