using UnityEngine;
using System.Collections;

public class SliderBehaviourScript : MonoBehaviour {
	
	private float HSlider = 0.0f;
	public GameObject BrickCube;
	
	public static int Threshold=0;
	public static int spacer=1;
	public static GameObject currentObject;
	
	// Use this for initialization
	void Start () 
	{
		Threshold++;
		CreateCubes();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{
		spacer++;
		HSlider	=GUI.HorizontalSlider(new Rect(400,350,100,30),HSlider,0.0f,10.0f);
		print(spacer);
		GetComponent<CubeBehaviourScript>().speed=HSlider*1000;
	}
	
	void CreateCubes()
	{	
		try
		{
			currentObject =GameObject.Find("Cube");
			float x = currentObject.transform.position.x,y= currentObject.transform.position.y,
					z= currentObject.transform.position.z;
			if(Threshold<10)
			Instantiate(currentObject,new Vector3(x,
				y+Threshold,z),Quaternion.identity);	
		}
		catch
		{
			print("Error occured");
		}
	}
}
