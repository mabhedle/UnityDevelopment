using UnityEngine;
using System.Collections;

public class NewObjectBehaviourScript : MonoBehaviour {
	
	public string Surname;
	public int Age;
	public float speed = 1000.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			
	
		transform.Rotate(0, speed*Time.deltaTime, 0);
		
		print(GetComponent<BoxCollider>().size.x);
		//this.gameObject.GetComponent<Rigidbody>().AddForce(50f,0f,0f);
		
	 	float input = Input.GetAxis("Horizontal");
		
		print(input);
	}
}
