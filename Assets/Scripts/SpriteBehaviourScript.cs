using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteBehaviourScript : MonoBehaviour
{

	public static int height = 80;
	public static int width = 80;
	public static int move = 8;
	public static int[,] grid = new int[100, 100];
	public GameObject myPrefab;
	private DisplayScript displayScript;

	void Awake() {
		displayScript = GameObject.FindObjectOfType<DisplayScript>();
	}

	// Start is called before the first frame update
	void Start() {
		this.GetComponent<SpriteBehaviourScript>().enabled = false;
	}

	// Update is called once per frame
	void Update() {
		if (Input.GetKeyDown(KeyCode.Return)) {
			if (this.gameObject.name.Substring(0, 2) == "Sg") Instantiate(myPrefab, new Vector3(-20, 60, 0), Quaternion.identity);
			else if (this.gameObject.name.Substring(0, 2) == "Tt") Instantiate(myPrefab, new Vector3(100, 60, 0), Quaternion.identity);
			else if (this.gameObject.name.Substring(0, 2) == "Ll") Instantiate(myPrefab, new Vector3(-20, 28, 0), Quaternion.identity);
			else if (this.gameObject.name.Substring(0, 2) == "Zz") Instantiate(myPrefab, new Vector3(100, 24, 0), Quaternion.identity);
			else Instantiate(myPrefab, new Vector3(-16, 24, 0), Quaternion.identity);
		}
		else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			foreach (Transform children in transform) {
				int xx = Mathf.RoundToInt(children.transform.position.x);
				int yy = Mathf.RoundToInt(children.transform.position.y);
				if (xx >= 0 && xx <= 80 && yy >= 0 && yy <= 80) {
					grid[xx, yy] -= 1;
				}
			}
			transform.position += new Vector3(-move, 0, 0);
			foreach (Transform children in transform) {
				int xx = Mathf.RoundToInt(children.transform.position.x);
				int yy = Mathf.RoundToInt(children.transform.position.y);
				if (xx >= 0 && xx <= 80 && yy >= 0 && yy <= 80) {
					grid[xx, yy] += 1;
				}
			}
			int area = 0;
			for (int i = 0; i < width; i++) {
				for (int j = 0; j < height; j++) {
					if (grid[i, j] > 0)
						area += 1;
				}
			}
			displayScript.Display(area);
		}
		else if (Input.GetKeyDown(KeyCode.RightArrow)) {
			foreach (Transform children in transform) {
				int xx = Mathf.RoundToInt(children.transform.position.x);
				int yy = Mathf.RoundToInt(children.transform.position.y);
				if (xx >= 0 && xx <= 80 && yy >= 0 && yy <= 80) {
					grid[xx, yy] -= 1;
				}
			}
			transform.position += new Vector3(move, 0, 0);
			foreach (Transform children in transform) {
				int xx = Mathf.RoundToInt(children.transform.position.x);
				int yy = Mathf.RoundToInt(children.transform.position.y);
				if (xx >= 0 && xx <= 80 && yy >= 0 && yy <= 80) {
					grid[xx, yy] += 1;
				}
			}
			int area = 0;
			for (int i = 0; i < width; i++) {
				for (int j = 0; j < height; j++) {
					if (grid[i, j] > 0)
						area += 1;
				}
			}
			displayScript.Display(area);
		}
		else if (Input.GetKeyDown(KeyCode.UpArrow)) {
			foreach (Transform children in transform) {
				int xx = Mathf.RoundToInt(children.transform.position.x);
				int yy = Mathf.RoundToInt(children.transform.position.y);
				if (xx >= 0 && xx <= 80 && yy >= 0 && yy <= 80) {
					grid[xx, yy] -= 1;
				}
			}
			transform.position += new Vector3(0, move, 0);
			foreach (Transform children in transform) {
				int xx = Mathf.RoundToInt(children.transform.position.x);
				int yy = Mathf.RoundToInt(children.transform.position.y);
				if (xx >= 0 && xx <= 80 && yy >= 0 && yy <= 80) {
					grid[xx, yy] += 1;
				}
			}
			int area = 0;
			for (int i = 0; i < width; i++) {
				for (int j = 0; j < height; j++) {
					if (grid[i, j] > 0)
						area += 1;
				}
			}
			displayScript.Display(area);
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			foreach (Transform children in transform) {
				int xx = Mathf.RoundToInt(children.transform.position.x);
				int yy = Mathf.RoundToInt(children.transform.position.y);
				if (xx >= 0 && xx <= 80 && yy >= 0 && yy <= 80) {
					grid[xx, yy] -= 1;
				}
			}
			transform.position += new Vector3(0, -move, 0);
			foreach (Transform children in transform) {
				int xx = Mathf.RoundToInt(children.transform.position.x);
				int yy = Mathf.RoundToInt(children.transform.position.y);
				if (xx >= 0 && xx <= 80 && yy >= 0 && yy <= 80) {
					grid[xx, yy] += 1;
				}
			}
			int area = 0;
			for (int i = 0; i < width; i++) {
				for (int j = 0; j < height; j++) {
					if (grid[i, j] > 0)
						area += 1;
				}
			}
			displayScript.Display(area);
		}
		else if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)) {
			foreach (Transform children in transform) {
				int xx = Mathf.RoundToInt(children.transform.position.x);
				int yy = Mathf.RoundToInt(children.transform.position.y);
				if (xx >= 0 && xx <= 80 && yy >= 0 && yy <= 80) {
					grid[xx, yy] -= 1;
				}
			}
			RotateLeft();
			foreach (Transform children in transform) {
				int xx = Mathf.RoundToInt(children.transform.position.x);
				int yy = Mathf.RoundToInt(children.transform.position.y);
				if (xx >= 0 && xx <= 80 && yy >= 0 && yy <= 80) {
					grid[xx, yy] += 1;
				}
			}
			int area = 0;
			for (int i = 0; i < width; i++) {
				for (int j = 0; j < height; j++) {
					if (grid[i, j] > 0)
						area += 1;
				}
			}
			displayScript.Display(area);
		}
	}

	void OnMouseDown() {
		this.GetComponent<SpriteBehaviourScript>().enabled = true;
	}

	void OnMouseUp() {
		this.GetComponent<SpriteBehaviourScript>().enabled = false;
	}

	void RotateLeft () {
		transform.Rotate (Vector3.forward * -90);
		if (this.gameObject.name.Substring(0, 2) == "Zz") {
			transform.position += new Vector3(move / 2, 0, 0);
			transform.position += new Vector3(0, move / 2, 0);
		}
	}
}
