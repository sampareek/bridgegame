using UnityEngine;
using System.Collections;

public class LoadCards : MonoBehaviour {
	
	private GameObject[] cards;
	private GameObject prefab_card;

	void Start () 
	{
		cards = GameObject.FindGameObjectsWithTag ("Cards_backimage");

		//while(cards[0])
			StartCoroutine (MoveTowardsTarget(0));

			StartCoroutine (MoveTowardsTarget(1));
	}

	void Update()
	{

	}

	private void placeCards()
	{

	}

	Vector3 getTargetPosition(int index)
	{
			float x = -4.50f;
			Vector3 position = new Vector3 ();
			position.x = x + index;
			position.y = -3.50f;
			position.z = 0;

		return position;
	}

	Vector3 getCurrentPosition(GameObject card)
	{
		return card.transform.position;
	}

	protected IEnumerator MoveTowardsTarget(int i) 
	{
		while (Vector3.Distance (getCurrentPosition (cards [i]), getTargetPosition (i)) > .1f) {
			cards [i].transform.position = Vector3.Lerp (getCurrentPosition (cards [i]), getTargetPosition (i), 2f * Time.deltaTime);
			yield return null;
		}
		Destroy(cards[i]);
		prefab_card = (GameObject)Resources.Load ("Prefabs/cards_c2");
		
		Vector3 card_position = new Vector3 ();
		card_position = getCurrentPosition (cards [i]);
		Instantiate (prefab_card, card_position, Quaternion.identity);
	}
}