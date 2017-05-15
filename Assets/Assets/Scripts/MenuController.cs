﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	public void StartButton()
	{
		SceneManager.LoadScene("start");

	}

	public void QuitButton() 
	{

		Application.Quit();
	}

	public void Preferences()
	{
		SceneManager.LoadScene("preferences");

	}
}
