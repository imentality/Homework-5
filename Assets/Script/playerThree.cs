using UnityEngine;
using System.Collections;

public class playerThree : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.I) ) {
			GetComponent<Rigidbody> ().AddForce (transform.forward * 1f, ForceMode.VelocityChange);
		}
		if (Input.GetKey (KeyCode.K) ) {
			GetComponent<Rigidbody> ().AddForce (transform.forward * -1f, ForceMode.VelocityChange);
		}
		if (Input.GetKey (KeyCode.J) ) {
			transform.Rotate ( new Vector3 (0f, -2f) );
		}
		if (Input.GetKey (KeyCode.L) ) {
			transform.Rotate ( new Vector3 (0f, 2f) );
		}
	}
}
