using UnityEngine;
using System.Collections;

public class JoinServerPage : MonoBehaviour {

	void OnMouseDown()
	{
		Application.LoadLevel (1);
		Debug.Log ("Scene changed Successfully");
	}
}
