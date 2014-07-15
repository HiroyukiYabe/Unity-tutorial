using UnityEngine;
using System.Collections;

public class BottomWallController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		void OnCollisionEnter(Collision collision) {
				Destroy(collision.gameObject);
		}
}
