using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Shooter : MonoBehaviour 
{

	public float power = 10f;
	public Rigidbody shotObject;
	public float fireRate = 0.5f;
	private float nextFire = 0.0f;
	static bool _launch = false;
	Text text;
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Input.GetMouseButton (0) && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Rigidbody tmpShot = Instantiate (shotObject, transform.position, transform.rotation) as Rigidbody;
			tmpShot.gameObject.tag = "Shot";
			tmpShot.AddForce (Camera.main.transform.forward * power, ForceMode.Impulse);
			GameController2.shotsFired += 1;
		} 
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			Application.Quit();
		}

	}
	

	void onStart() 
	{
		text = GetComponent<Text> ();
	}
}
