using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public UnityEngine.UI.Text scoreLabel;
	public GameObject winnerLabelObject;

	void Update () {
		int count = GameObject.FindGameObjectsWithTag ("Item").Length;
		scoreLabel.text = count.ToString();

		// すべてのアイテムが消えたら、クリアメッセージを出す
		if (count == 0) {
			winnerLabelObject.SetActive (true);
		}
	}
}
