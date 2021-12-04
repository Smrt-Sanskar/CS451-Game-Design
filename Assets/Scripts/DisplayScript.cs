using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScript : MonoBehaviour
{

	public Text myText;
	public int cnt;

	void Update() {
		if (Input.GetKeyDown(KeyCode.Return)) {
			cnt++;
		}
	}

	public void Display(int area) {
		if (area == 100) myText.text = "Congrats!! You covered whole area using " + cnt.ToString() + " pieces.";
		else myText.text = "Area Covered: " + area.ToString() + " & Pieces Used: " + cnt.ToString();
	}
}
