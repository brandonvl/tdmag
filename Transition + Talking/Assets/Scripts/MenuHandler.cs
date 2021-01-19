using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.Events; // This is so that you can extend the pointer handlers
using UnityEngine.EventSystems; // This is so that you can extend the pointer handlers

public class MenuHandler : MonoBehaviour
{
    private Text selectedTextField;
    public Text txtStartGame;
    public Text txtOptions;

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("MenuHandler.Start");
        txtStartGame.color = Color.blue;
        this.selectedTextField = this.txtStartGame;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown("down") || Input.GetKeyDown("up"))
        {
            changeSelectedText();
        }
        else if (Input.GetKeyDown("return"))
        {
            loadSelectedScene();
        }
    }

    private void changeSelectedText()
    {
        selectedTextField.color = Color.black;
        if (selectedTextField == txtStartGame)
        {
            selectedTextField = txtOptions;
        }
        else
        {
            selectedTextField = txtStartGame;
        }
        selectedTextField.color = Color.blue;
    }

    private void loadSelectedScene()
    {
        if (selectedTextField == txtStartGame)
        {
            SceneManager.LoadScene(Globals.SceneIndexOverview);
        }
        else
        {
            SceneManager.LoadScene(Globals.SceneIndexOptions);
        }
    }
}

// Placed in first run script
public static class Globals
{
    public const int SceneIndexMenu = 0;
    public const int SceneIndexOptions = 1;
    public const int SceneIndexOverview = 2;
    public const int SceneIndexBattle = 3;
}