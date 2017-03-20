using UnityEngine;
using System.Collections;

[System.Serializable]
public class TileStyle {

	public int Number;
	public Color32 tileColor;
	public Color32 textColor;

}

public class StyleHolder : MonoBehaviour {

	// SINGLETON
	public static StyleHolder Instance;

	public TileStyle[] TileStyles;

	void Awake () {
		Instance = this;
	}


}
