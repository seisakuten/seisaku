using UnityEngine;
using System.Collections;

public class UnityBehaviour : MonoBehaviour {
    
	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("up")) {
			transform.position += transform.forward * 0.1f;
			animator.SetBool("Run", true);
		} else {
			animator.SetBool("Run", false);
		}
		if (Input.GetKeyDown("right")) {
			transform.Rotate(0,  180, 0);
		}
		if (Input.GetKeyDown ("left")) {
			transform.Rotate(0, 180, 0);
		}
	}
}
