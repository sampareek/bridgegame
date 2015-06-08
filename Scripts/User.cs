using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	private string name;
	private int user_id;
	private Time dateofjoin;

	public void registration(string uname, int uid)
	{
		this.name = uname;
		this.user_id = uid;
		this.dateofjoin = System.DateTime.Now;
	}

	public string getName()
	{
		return name;
	}

	public string getUser_id()
	{
		return user_id;
	}

	public string getDateofjoin()
	{
		return dateofjoin;
	}
}
