using UnityEngine;
using System.Collections;

public class SampleMobe : MonoBehaviour {

	public float moveTime = 0.1f;           //Time it will take object to move, in seconds.
	
	private Rigidbody2D rb2D;               //The Rigidbody2D component attached to this object.
	private float inverseMoveTime;          //Used to make movement more efficient.
	public GameObject[] cards;
	int c = 0;
	protected virtual void Start ()
	{
	//	Joint.FindObjectsOfType(Rigidbody2D) =  GameObject.FindGameObjectsWithTag("Cards_backimage");
	//	rb2D = GetComponents <Rigidbody2D> ();
		cards = GameObject.FindGameObjectsWithTag ("Cards_backimage");
	//	Debug.Log (cards[0].name);
	//	Debug.Log (cards[1].name);
		rb2D = cards [0].GetComponent<Rigidbody2D> ();

	//	Debug.Log (rb2D.name);
		inverseMoveTime = 1f / moveTime;
		Vector3 end = new Vector3 ();
			end.x = -6f;
			end.y = -4f;
			end.z = 0f;
		StartCoroutine(SmoothMovement (end));

		rb2D = cards [1].GetComponent<Rigidbody2D> ();
		StartCoroutine(SmoothMovement (end));
	}

	protected IEnumerator SmoothMovement (Vector3 end)
	{
		//Calculate the remaining distance to move based on the square magnitude of the difference between current position and end parameter. 
		//Square magnitude is used instead of magnitude because it's computationally cheaper.
		float sqrRemainingDistance = (rb2D.transform.position - end).sqrMagnitude;
		
		//While that distance is greater than a very small amount (Epsilon, almost zero):
		while(sqrRemainingDistance > float.Epsilon)
		{
			//Find a new position proportionally closer to the end, based on the moveTime
			Vector3 newPostion = Vector3.MoveTowards(rb2D.position, end, inverseMoveTime * Time.deltaTime);
			
			//Call MovePosition on attached Rigidbody2D and move it to the calculated position.
			rb2D.MovePosition (newPostion);
			
			//Recalculate the remaining distance after moving.
			sqrRemainingDistance = (transform.position - end).sqrMagnitude;
			
			//Return and loop until sqrRemainingDistance is close enough to zero to end the function
			yield return null;
		}
	}		
}