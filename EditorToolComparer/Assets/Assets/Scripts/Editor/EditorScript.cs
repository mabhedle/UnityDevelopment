using UnityEngine;
using System.Collections;
using UnityEditor;

public class EditorScript : EditorWindow 
{
	/*public GameObject obj;
	public string ObjectName;	
	
	[MenuItem("Window/Window A")]
	public static void ShowWindow()
	{
		var window = EditorWindow.GetWindow(typeof(ObjeectAScript));	
		
		
	}
	
	void OnGUI()
	{
		GUILayout.Label("Section A",EditorStyles.boldLabel);
		if((obj = (GameObject)EditorGUILayout.ObjectField(obj,typeof(GameObject),true)))
		{
		
			if(obj!=null)
			{
				var componentList = obj.GetComponents<Component>();
				
				arrayGroup = new bool[componentList.Length];
				
				int index=0;
				foreach(var item in componentList)
				{
				 	arrayGroup[index] = EditorGUILayout.BeginToggleGroup("",arrayGroup[index]);
					EditorGUILayout.ObjectField(item,typeof(Component),true);
					EditorGUILayout.EndToggleGroup();
					index++;
				}
				EditorGUILayout.Toggle(true,"Game Components");
				
				
				
			}
		}
		
		
		for(int i =0;i<arrayGroup.Length;i++)
		{
			if(arrayGroup[i])
			{
				
			}
		}
		
		if(GUILayout.Button("Search"))
		{
			
		}
	}*/
}
