using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Collections.Generic;

public class EditorBScript : EditorWindow 
{
	public GameObject sourceObject, targetObject;
	public string ObjectName;
	public bool boxCollider=false;
	public bool groupToggle=false;
	public bool[] sourceObjectToggles,targetObjectToggles,filteredComponent,validObjectComponents;
	public static int flag=0,flagTwo=0;
	public Component[] sourceObjectComponents, targetObjectComponents;
	
	
	
	[MenuItem("Window/Window B")]
	public static void ShowWindow()
	{
		EditorWindow.GetWindow(typeof(EditorBScript));
		
		
	}
	
	void UpdateSourceObject(GameObject userObject)
	{
		sourceObject = userObject;
		if (null == sourceObject)
		{
			sourceObjectComponents = null;
			sourceObjectToggles = null;
		}
		else
		{
			sourceObjectComponents = sourceObject.GetComponents<Component>();
			sourceObjectToggles = new bool[sourceObjectComponents.Length];
		}
	}
	void UpdateTargetObject(GameObject userObject)
	{
		targetObject = userObject;
		
		if(null==targetObject)
		{
			targetObjectComponents=null;
			targetObjectToggles=null;
		}
		else
		{
			targetObjectComponents = targetObject.GetComponents<Component>();
			targetObjectToggles = new bool[targetObjectComponents.Length];
		}
	}
	bool[] CompareSourceToTarget(Component[] targetComponents,Component[] sourceComponents)
	{
		filteredComponent = new bool[sourceComponents.Length];
		validObjectComponents = new bool[sourceComponents.Length];
		
		for(int x = 0;x<sourceComponents.Length;x++)
		{
			for(int y=0;y<targetComponents.Length;y++)
			{
				if(targetComponents[y].GetType()!=sourceComponents[x].GetType())
				{
					filteredComponent[x]= false;	
					
				}
				else
				{
					filteredComponent[x]= true;
					validObjectComponents[x] = sourceComponents[x];
					break;
				}
			}
		}
		return filteredComponent;
	}
	
	void OnGUI()
	{
		GUILayout.Label("Section B",EditorStyles.boldLabel);
		
		EditorGUILayout.BeginVertical("Box");
		EditorGUILayout.LabelField("Source Object",EditorStyles.boldLabel);
		var userObject = (GameObject)EditorGUILayout.ObjectField(sourceObject,typeof(GameObject),true);
		if (userObject != sourceObject)
		{
			UpdateSourceObject(userObject);
		}
		if(sourceObject!=null)
		{
			for (int index = 0; index < sourceObjectComponents.Length; ++index) 
			{
				if(targetObject!=null)
				{
					var filteredComponentFlags = CompareSourceToTarget(targetObjectComponents,sourceObjectComponents);
					if(filteredComponentFlags[index])
					{
			 			sourceObjectToggles[index] = EditorGUILayout.Toggle(
						(sourceObjectComponents[index].GetType()).Name,
						sourceObjectToggles[index]);
					}
				}
				else
				{
					sourceObjectToggles[index] = EditorGUILayout.Toggle(
					(sourceObjectComponents[index].GetType()).Name,
					sourceObjectToggles[index]);
				}
			}
		}
		
		EditorGUILayout.EndVertical();
		
		
		EditorGUILayout.BeginVertical("Box");
		EditorGUILayout.LabelField("Target Object",EditorStyles.boldLabel);
	 	var userTargetObject=(GameObject)EditorGUILayout.ObjectField(targetObject,typeof(GameObject),true);
		if(targetObject!=userTargetObject)
		{
			UpdateTargetObject(userTargetObject);
		}
		if(targetObject!=null)
		{
			
		
				for(int index =0;index<targetObjectComponents.Length;++index)
				{
					EditorGUILayout.LabelField((targetObjectComponents[index].GetType()).Name,EditorStyles.boldLabel);
				 	
				}
			
		
		EditorGUILayout.EndVertical();
		
			if(GUILayout.Button("Make Changes"))
			{
				for(int index=0;index<sourceObjectToggles.Length;index++)
				{
					if(sourceObjectToggles[index])
					{
						var selectedComponent = sourceObjectComponents[index];
					
						System.Type type = selectedComponent.GetType();
						
						Component copy =null;
						for(int y=0;y<targetObjectComponents.Length;y++)
						{
							if(type == targetObjectComponents[y].GetType())
							{
								copy = targetObjectComponents[y];
								
								System.Reflection.FieldInfo[] fields = copy.GetType().GetFields(); 
						
						
    							foreach (System.Reflection.FieldInfo field in fields)
    							{
	   								field.SetValue(copy, field.GetValue(selectedComponent));
   								}
								break;
							}
						
						}
					}
					
				}
			}
		}
	}
}
