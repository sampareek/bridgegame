using UnityEngine;
using System.Collections;
using System;

public class Player : MonoBehaviour {

	public Player()
	{
		dateofjoin = System.DateTime.Now;
		cards = new int[13];
		bid = new int[28]; //maximum no of bids ..need to relook in this.
		isDummy = false;
		isBidStarter = false;
		bid_count = 0;
	}

	public void setCards() //this function assigns cards to player when game starts
	{
		Cards card_obj = new Cards ();
		cards = card_obj.distributeCards (); // need to relook
	}

	public int[] fectchCardsforDuplicate()
	{
		return cards;
	}

	public DateTime getDateofJoin()
	{
		return dateofjoin;
	}

	public int[] getCards()
	{
		return cards;
	}

	public int[] getBid()
	{
		return bid;
	}

	public void setBid(int bid_value)
	{
		bid[bid_count] = bid_value;
		bid_count++;
	}

	public void setPosition(char postion)
	{
		this.position = position;
	}

	public char getPosition()
	{
		return position;
	}

	public void setisDummy(bool dummy)
	{
		isDummy = dummy;
	}

	public bool getisDummy()
	{
		return isDummy;
	}

	public bool getisBidStarter()
	{
		return isBidStarter;
	}

	public void setisBidStarter(bool bid_status)
	{
		isBidStarter = bid_status;
	}

	private Time dateofjoin;
	private int[] cards;
	private int[] bid;
	private char position;//identifies position of player like N for north and for others
	private bool isDummy;
	private bool isBidStarter;
	private int bid_count; //use to count the no of times user has gave the bid
}
