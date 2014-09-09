using UnityEngine;
using System.Collections;

public class ObjectBuilderScript : MonoBehaviour {

	public GameObject obj;
	public Vector3 spawner;
	//public static bool created = false;
	
	void Start()
	{
		if(obj==null)
		{
			obj = this.gameObject;
		}
		
	}
	
	void Update()
	{
		
	}
	
	public void BuildObject()
	{
		Instantiate(obj,spawner,Quaternion.identity);
		
	}
	
	void Awake()
	{
		
		if(!GameState.created)
		{
			
			GameState.created =true;
		}
		else
		{
			
			DontDestroyOnLoad(obj);
		}
		print("Awake method");
	}
	
	void OnDisable()
	{
		print("End	");
	}
}
