using UnityEngine;
using System.Collections;

public class playerOne : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W) ) {
			GetComponent<Rigidbody> ().AddForce (transform.forward * 1f, ForceMode.VelocityChange);
		}
		if (Input.GetKey (KeyCode.S) ) {
			GetComponent<Rigidbody> ().AddForce (transform.forward * -1f, ForceMode.VelocityChange);
		}
		if (Input.GetKey (KeyCode.A) ) {
			transform.Rotate ( new Vector3 (0f, -2f) );
		}
		if (Input.GetKey (KeyCode.D) ) {
			transform.Rotate ( new Vector3 (0f, 2f) );
		}
	}
}
