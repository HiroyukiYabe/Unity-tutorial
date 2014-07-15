using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	public float speed = 5.0f;

	// Use this for initialization
	void Start () {
		rigidbody.AddForce((transform.forward*2 + transform.right) * speed, ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
