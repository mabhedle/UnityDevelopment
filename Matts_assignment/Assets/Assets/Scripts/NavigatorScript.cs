using UnityEngine;
using System.Collections;

public class NavigatorScript : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	void OnGUI()
	{
		if(GUILayout.Button("Start Game"))
		{
			Application.LoadLevel("Level02");
		}
	}
}
