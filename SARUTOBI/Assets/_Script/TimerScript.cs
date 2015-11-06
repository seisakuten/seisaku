using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerScript : MonoBehaviour {

	private float time = 60;

	// Use this for initialization
	void Start () {
		//show initial value "60"
		GetComponent<Text> ().text = ((int)time).ToString ();
	}
	
	// Update is called once per frame
	void Update () {

		time -= Time.deltaTime;

		if (time < 0)
			time = 0;
		GetComponent<Text> ().text = ((int)time).ToString ();
	
	}
}
