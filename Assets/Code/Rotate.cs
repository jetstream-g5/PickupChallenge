using UnityEngine;
using System.Collections;

public class Rotate : Pickup {
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public override void PlayerHit(Player _GO)
	{
		_GO.RotatePlayer ();
		base.PlayerHit(_GO);//roep de basis classe nog wel aan(dus de playerhit in pickup)
	}
}
