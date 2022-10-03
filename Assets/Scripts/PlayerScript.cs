using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Transform chadGrave;
    // [SerializeField] private GameObject textPrompt;
    private bool upTrigger;
    private bool downTrigger;
    private float playerSpd = 15f;
    private float ySpd = 5f;
    private float horiMove;
    private float vertMove;

    void Update()
    {
        upTrigger = Input.GetKey(KeyCode.Space);
        downTrigger = Input.GetKey(KeyCode.LeftShift);
        horiMove = Input.GetAxisRaw("Horizontal");
        vertMove = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        if(upTrigger)
        {
            rb.AddForce(Vector3.up * ySpd, ForceMode.VelocityChange);
        }
        if(downTrigger)
        {
            rb.AddForce(Vector3.down * ySpd, ForceMode.VelocityChange);
        }
        rb.velocity = new Vector3(horiMove * playerSpd, rb.velocity.y, vertMove * playerSpd);
        // ctrler.Move(new Vector3(horiMove, upTrigger ? 1.0f : downTrigger ? -1.0f : 0.0f, vertMove) * playerSpd * Time.deltaTime);
    }
}