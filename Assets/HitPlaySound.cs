using UnityEngine;
using System.Collections;

public class HitPlaySound : MonoBehaviour {

	public AudioClip sound;
		void OnCollisionEnter(Collision collision) {
			AudioSource.PlayClipAtPoint(sound, transform.position);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
