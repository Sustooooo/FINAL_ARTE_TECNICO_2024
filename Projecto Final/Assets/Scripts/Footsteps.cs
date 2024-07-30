using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource FootStepsSound;
    public Footsteps StepsScript;

    void Start()
    {
        StepsScript.gameObject.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
            FootStepsSound.enabled = true;
        else
        {
            FootStepsSound.enabled = false;
        }
    }
}
