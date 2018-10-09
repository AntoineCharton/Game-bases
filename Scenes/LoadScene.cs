using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
	public string SceneName;
	// Use this for initialization

	public void Load(){
		SceneManager.LoadScene(SceneName);
	}
}
