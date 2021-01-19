using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("BattleHandler.Start");
    }

    // Update is called once per frame
    private void Update()
    {
        //Debug.Log("GameHandler.Update");

        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Space is pressed");
            SceneManager.LoadScene(Globals.SceneIndexOverview);
        }
    }
}