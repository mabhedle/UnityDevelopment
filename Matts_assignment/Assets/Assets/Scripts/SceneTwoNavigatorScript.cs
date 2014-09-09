using UnityEngine;
using System.Collections;

public class SceneTwoNavigatorScript : MonoBehaviour {

	void OnGUI()
	{
		if(GUILayout.Button("Go Back"))
		{
			Application.LoadLevel("Level01");
		}
			
	}
}
