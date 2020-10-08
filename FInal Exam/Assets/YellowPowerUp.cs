using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class YellowPowerUp : PowerUp
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.J))
        {
            this.Activate();
        }
    }

    public override void Activate()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("SceneTwo"))
        {
            SceneManager.LoadScene("SceneOne");
        }
        else
        {
            SceneManager.LoadScene("SceneTwo");
        }
    }
}
