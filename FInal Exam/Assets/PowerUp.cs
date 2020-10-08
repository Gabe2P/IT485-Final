using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class PowerUp : MonoBehaviour, Interactable
{
    private Collider hitbox;
    [HideInInspector]public PlayerController playerController = null;

    // Start is called before the first frame update
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
        hitbox = GetComponent<Collider>();
        hitbox.isTrigger = true;
    }

    public void OnTriggerEnter(Collider other)
    {
        PlayerController player = other.GetComponent<PlayerController>();

        if (player != null)
        {
            playerController = player;
            this.Activate();
        }
    }

    public virtual void Activate()
    {

    }
}
