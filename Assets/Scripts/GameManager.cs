using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject gameBoard;
	public GameObject[] currentTiles;
	public GameObject[] allTiles;

	private GridLayoutGroup grid;

	// Use this for initialization
	void Start () {
		
		gameBoard = GameObject.Find("GameBoard");
		currentTiles = new GameObject[gameBoard.transform.childCount];

		allTiles = new GameObject[gameBoard.transform.childCount];
		allTiles = Resources.LoadAll<GameObject> ("Prefabs");


		for (int i = 0; i < currentTiles.Length; i++) {
			currentTiles [i] = gameBoard.transform.GetChild (i).gameObject;
		}

		grid = this.GetComponentInChildren<GridLayoutGroup> ();

		Reset ();

	}

	// Update is called once per frame
	void Update () {

	}

	void Reset() {

		foreach (GameObject g in currentTiles) {
			Destroy (g);
		}




	}
}
