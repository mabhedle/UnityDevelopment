using UnityEngine;
using UnityEditor;
using System.Collections;


[CustomEditor(typeof(ObjectBuilderScript))]
public class ObjectBuilderEditor : Editor 
{	
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();
		
		var myScript = (ObjectBuilderScript)target;
		
		if(GUILayout.Button("Build Object"))
		{
			myScript.BuildObject();
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