using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ouvrirScene : MonoBehaviour
{
	public string nomScene;
	public void loadScene(){ 
		SceneManager.LoadScene(nomScene);
	}
}
