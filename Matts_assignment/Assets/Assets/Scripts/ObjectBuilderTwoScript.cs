using UnityEngine;
using System.Collections;

public class ObjectBuilderTwoScript : MonoBehaviour {

	public Texture texture;
	
	
	public void ApplyTexture()
	{
			renderer.material.mainTexture = texture;
	}
}
