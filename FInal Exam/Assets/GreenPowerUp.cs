using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPowerUp : PowerUp
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.O))
        {
            this.Activate();
        }
    }

    public override void Activate()
    {
        playerController.rb.useGravity = true;
        MeshRenderer mesh = playerController.gameObject.GetComponent<MeshRenderer>();

        if (mesh != null)
        {
            mesh.material.color = Color.green;
        }
    }
}
