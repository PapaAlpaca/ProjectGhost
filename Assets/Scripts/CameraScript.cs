using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject camBase;
    private Vector3 offset;
    private float dist;
    private float rotateSpd = 3;
    void Start()
    {
        offset = player.transform.position - transform.position;
        dist = Mathf.Sqrt(offset.x*offset.x + offset.z*offset.z);
    }

    void LateUpdate()
    {
        float hori = Input.GetAxis("Mouse X") * rotateSpd;
        camBase.transform.Rotate(0, hori, 0);
    }
}
