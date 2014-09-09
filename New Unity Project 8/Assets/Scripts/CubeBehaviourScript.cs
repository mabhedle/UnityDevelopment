using UnityEngine;
using System.Collections;

public class CubeBehaviourScript : MonoBehaviour {

	// Use this for initialization
	public float speed=0.0f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate(0, speed*Time.deltaTime, 0);
	}
	
}
