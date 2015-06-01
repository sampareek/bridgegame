using UnityEngine;
using System.Collections;

public class Hands : MonoBehaviour {
	private int[] handCards;
	private char firstTurn;
	private char handWinner;

	public Hands(char player)
	{
		firstTurn = player;
		handCards = new int[4];
	}

	public void findHighCard(string trump_suit)
	{
		//build logic and decides handWinner
	}

	public void addCard()
	{
		// build logic... this adds cards to handcards;
	}

	public void setFirstTurn(char player)
	{
		firstTurn = player;
	}

	public char gerFirstTurn()
	{
		return firstTurn;
	}

	public char gethandWinner()
	{
		return handWinner;
	}

}
