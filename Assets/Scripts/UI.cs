using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour {

    public GameObject canvas;
    public static bool gameOver = false;

	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(gameOver)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            gameOver = false;
        }
	}

    public void Play()
    {
        Time.timeScale = 1;
        canvas.SetActive(false);
    }
}
