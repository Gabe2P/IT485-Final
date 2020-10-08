using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPowerUp : PowerUp
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H) || Input.GetKeyDown(KeyCode.P))
        {
            this.Activate();
        }
    }

    public override void Activate()
    {
        playerController.rb.useGravity = false;
        MeshRenderer mesh = playerController.gameObject.GetComponent<MeshRenderer>();

        if (mesh != null)
        {
            mesh.material.color = Color.red;
        }
    }
}
