using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.Events; // This is so that you can extend the pointer handlers
using UnityEngine.EventSystems; // This is so that you can extend the pointer handlers

public class OptionsHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("OptionsHandler.Start");
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            SceneManager.LoadScene(Globals.SceneIndexMenu);
        }
    }
}