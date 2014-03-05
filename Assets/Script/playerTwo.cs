using UnityEngine;
using System.Collections;

public class playerTwo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.T) ) {
			GetComponent<Rigidbody> ().AddForce (transform.forward * 1f, ForceMode.VelocityChange);
		}
		if (Input.GetKey (KeyCode.G) ) {
			GetComponent<Rigidbody> ().AddForce (transform.forward * -1f, ForceMode.VelocityChange);
		}
		if (Input.GetKey (KeyCode.F) ) {
			transform.Rotate ( new Vector3 (0f, -2f) );
		}
		if (Input.GetKey (KeyCode.H) ) {
			transform.Rotate ( new Vector3 (0f, 2f) );
		}
	}
}
