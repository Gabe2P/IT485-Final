using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NPC : MonoBehaviour
{
    [HideInInspector] public NavMeshAgent nav;
    public PlayerController player;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            player = FindObjectOfType<PlayerController>();
        }

        MeshRenderer mesh = player.GetComponent<MeshRenderer>();

        if (Vector3.Distance(this.transform.position, player.transform.position) <= 2)
        {
            if (mesh != null)
            {
                mesh.material.color = Color.yellow;
            }

            if (Vector3.Distance(this.transform.position, player.transform.position) <= 1)
            {
                if (mesh != null)
                {
                    mesh.material.color = Color.red;
                }
            }
        }
        else
        {
            if (mesh != null)
            {
                mesh.material.color = Color.green;
            }
        }

        nav.destination = player.transform.position;
        if (anim != null)
        {
            if (nav.velocity != Vector3.zero)
            {
                anim.SetBool("Moving", true);
            }
            else
            {
                anim.SetBool("Moving", false);
            }
        }
    }
}
