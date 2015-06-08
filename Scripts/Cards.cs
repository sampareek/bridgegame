using UnityEngine;
using System.Collections;

public class Cards : MonoBehaviour {

	public Cards()
	{
		deck = new bool[52];
		reset ();
	}

	private void reset()
	{
		for (int i=0; i<52; i++) {
			deck[i] = false;
		}
	}

	//this function gives cards to player
	public int[] distributeCards()
	{
		int[] thirteenCards = new int[13];
		/*
		 * make a logic whose deck[i] is false;
			logic to shuffle the cards
			Sort the cards.
		*/
		return thirteenCards;
	}

	private bool[] deck;
}
