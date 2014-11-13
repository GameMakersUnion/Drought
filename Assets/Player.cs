using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {

	const float moveDist = 0.1f;

	GameObject p1, p2;

	List<Direction> p1Directions;
	List<Direction> p2Directions;

	private class Direction {
		public Direction (KeyCode k, float _v, float _h) {
			this.key = k;
			this.v = _v;
			this.h = _h;
		}
		public KeyCode key;
		public float v;
		public float h;
	}

/*

	private class Directions{
		KeyCode Up;
		KeyCode Down;
		KeyCode Left;
		KeyCode Right;
	}
	private Dictionary<Players, KeyCode> mapKeyboard = new Dictionary<Players, Directions>(){

		{Players.p1, new Directions(KeyCode.W, KeyCode.S, KeyCode.A, KeyCode.D) },
		{Players.p2, new Directions(KeyCode.UpArrow, KeyCode.DownArrow, KeyCode.LeftArrow, KeyCode.RightArrow) },
	};

*/
	// Use this for initialization
	void Start () {
		p1Directions = new List<Direction>() {
			new Direction(KeyCode.UpArrow, 1, 0),
			new Direction(KeyCode.DownArrow, -1, 0),
			new Direction(KeyCode.LeftArrow, 0, -1),
			new Direction(KeyCode.RightArrow, 0, 1)
		};
		p2Directions = new List<Direction>() {
			new Direction(KeyCode.W, 1, 0),
			new Direction(KeyCode.S, -1, 0),
			new Direction(KeyCode.A, 0, -1),
			new Direction(KeyCode.D, 0, 1)
		};

		p1 = GameObject.Find ("Player1");
		p2 = GameObject.Find ("Player2");
	}
	
	// Update is called once per frame
	void Update () {

		foreach (var dir in p1Directions) {
			if (Input.GetKey(dir.key)) {
				
				float v = 0f;
				float h = 0f;

				v = dir.v;
				h = dir.h;
				
				if ( h!=0f || v!=0f ){
					var t = p1.transform;
					t.position = new Vector3( t.position.x + h * moveDist, t.position.y + v * moveDist, t.position.z);
				}

			}
		}

		foreach (var dir in p2Directions) {
			if (Input.GetKey(dir.key)) {
				
				float v = 0f;
				float h = 0f;
				
				v = dir.v;
				h = dir.h;
				
				if ( h!=0f || v!=0f ){
					var t = p2.transform;
					t.position = new Vector3( t.position.x + h * moveDist, t.position.y + v * moveDist, t.position.z);
				}
				
			}
		}

		/*
		if ( Input.GetKey( mapKeyboard.ContainsKey(player) )){
			Debug.Log ( player + "," + mapKeyboard[player] );
		}
*/
	}
}
 