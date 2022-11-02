using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    private bool upTrigger, downTrigger;
    private float flatSpd = 15f;
    private float ySpd = 5f;
    private float turnSpd = 200f;
    private float horiMove, vertMove;

    void Update()
    {
        upTrigger = Input.GetKey(KeyCode.Space);
        downTrigger = Input.GetKey(KeyCode.LeftShift);
        horiMove = Input.GetAxisRaw("Horizontal");
        vertMove = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.angularVelocity = Vector3.zero;
        rb.AddForce((upTrigger ? Vector3.up : (downTrigger ? Vector3.down : Vector3.zero)) * ySpd, ForceMode.VelocityChange);
        transform.Translate(0, 0, vertMove * flatSpd * Time.deltaTime);
        transform.Rotate(0, horiMove * turnSpd * Time.deltaTime, 0);
    }
}
