using UnityEngine;
using System.Collections;

public class Slow : Pickup {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void PlayerHit(Player _GO)
	{
		_GO.SlowPlayer ();
		base.PlayerHit(_GO);//roep de basis classe nog wel aan(dus de playerhit in pickup)
		/*print ("slow hit");
		var player = gameObject.GetComponent<Player> ();
		//player.SlowPlayer ();*/
	}
	
}
