using UnityEngine;
using UnityEditor;
using System.Collections;


[CustomEditor(typeof(ObjectBuilderTwoScript))]
public class ObjectBuilderTwoEditor : Editor 
{	
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();
		
		var myScript = (ObjectBuilderTwoScript)target;
		
		if(GUILayout.Button("Add Texture"))
		{
			myScript.ApplyTexture();
		}
		
		/*if(GUILayout.Button("Rotate ClockWise"))
		{
			myScript.RotateClockWise();
		}
		
		if(GUILayout.Button("Apply Texture"))
		{
			myScript.ApplyTexture();
		}*/
		
		
		
	}
}