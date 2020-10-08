using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SphereCollider))]
public class PlayerController : MonoBehaviour
{

    [HideInInspector]public Vector2 moveInput = Vector2.zero;
    public float moveSpeed = 5f;
    public float jumpSpeed = 5f;

    [HideInInspector]public Rigidbody rb;
    [HideInInspector]public bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Vector2.zero;

        moveInput.x = Input.GetAxisRaw("Horizontal") * moveSpeed;
        moveInput.y = Input.GetAxisRaw("Vertical") * moveSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        Vector3 nextPosition = new Vector3(rb.position.x + moveInput.x * Time.fixedDeltaTime, rb.position.y, rb.position.z + moveInput.y * Time.fixedDeltaTime);
        rb.MovePosition(nextPosition);

    }

    private void Jump()
    {
        if (isGrounded)
        {
            Vector3 jumpForce = new Vector3(0, jumpSpeed, 0);
            rb.AddForce(jumpForce, ForceMode.Impulse);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        NPC enemy = other.GetComponent<NPC>();

        if (enemy != null)
        {
            Destroy(enemy.gameObject);
        }
    }
}
