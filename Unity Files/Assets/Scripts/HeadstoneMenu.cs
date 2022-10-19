using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadstoneMenu : MonoBehaviour
{
    private readonly int SCENE_CHAD = 2;
    [SerializeField] private Transform player;
    [SerializeField] private Transform chadGrave;
    [SerializeField] private GameObject chadPrompt;
    private bool chadPopup = false;

    void Start()
    {
        chadPrompt.SetActive(false);
    }

    void Update()
    {
        if(isCloseEnough(player.position, chadGrave.position, 5.0f))
        {
            if(!chadPopup)
            {
                chadPrompt.SetActive(true);
                chadPopup = true;
            }
            if(Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(SCENE_CHAD);
            }
        }
        else
        {
            chadPrompt.SetActive(false);
            chadPopup = false;
        }
    }

    private bool isCloseEnough(Vector3 a, Vector3 b, float range)
    {
        return Mathf.Abs(a.x - b.x) < range && Mathf.Abs(a.y - b.y) < range && Mathf.Abs(a.z - b.z) < range;
    }
}
