using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 offset;
    private float rotateSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        offset = player.transform.position - transform.position;
    }
    void LateUpdate()
    {
        float hori = Input.GetAxis("Mouse X") * rotateSpeed;
        player.transform.Rotate(0, hori, 0);
        float desiredAngle = player.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = player.transform.position - (rotation * offset);
        transform.LookAt(player.transform);
        // float currAng = transform.eulerAngles.y;
        // float desAng = target.transform.eulerAngles.y;
        // float theta = Mathf.LerpAngle(currAng, desAng, Time.deltaTime * damp);
        // Quaternion rotation = Quaternion.Euler(0, theta, 0);
        // transform.position = target.transform.position - (rotation * offset);
        // transform.LookAt(target.transform);
    }
}
