﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelPoint : MonoBehaviour
{
    public void RestartLevelPoint()
    {
        gameObject.transform.position = new Vector3(6.72f, 1.68f, 0);
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            GameController.instance.AddCurrentLevel();
            if (GameController.instance.GetCurrentLevel() < PlayerPrefs.GetInt("LenghtGame"))
            {
                GameController.instance.ReloadGame(true);    
            }
            else
            {
                SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings-1); // Credits Scene
            }
        }
    }
}