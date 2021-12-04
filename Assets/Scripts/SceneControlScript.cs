using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControlScript : MonoBehaviour
{
	public void LoadScene(string sceneName) {
		SceneManager.LoadScene(sceneName);
	}

	public void Return() {
		SceneManager.LoadScene("menu");
	}

	public void Quit() {
		UnityEditor.EditorApplication.isPlaying = false;
	}
}
