using UnityEngine;
using System.Collections;

public class Table : MonoBehaviour {


	public Table()
	{

	}

	public void playCard()
	{
		//user plays a card
	}

	public bool validateCard()
	{
		//checks card is valid or not 
	}

	public void countHands()
	{
		//logic part
		//difine ogject for hands 
	}

	public void setBidStarter()
	{
		//logic part
	}

	public void setDummy()
	{
		///logic part;
	}

	public void fetchCardsforDuplicate()
	{
		// logic part;
	}

	private int tableid;
	private Player northPlayer;
	private Player southPlayer;
	private Player westPlayer;
	private Player eastPlayer;
	private string previousBid;
	private Hands[] allHands;
	private int passcounter;
	private string maxBid;
	private string trumpSuit; // heart / spade / diamond / club
	private int points;
	private int hands_NS; // stores hands acquired by north and south
//	private int hands_EW; can fetch by 13-hands_NS
}