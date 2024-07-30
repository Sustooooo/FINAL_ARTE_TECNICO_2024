using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Open_Door : MonoBehaviour
{
    public TextMeshProUGUI LokedOpen;
    public TextMeshProUGUI FindTheKey;
    public AudioSource LokedDoorSound;
    public AudioSource OpenDoorSound;
    public GameObject NoiseTV;
    public RawImage fade;
    public GameObject menuFin;
    public GameObject Player;
    public Animator anim;


    float fadeConstans = 0;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            LokedOpen.gameObject.SetActive(true);
            FindTheKey.gameObject.SetActive(true);
            PlayerController playerController = other.GetComponent<PlayerController>();


            if (playerController.hasKey)
            {
                LokedOpen.text = "[E] Open";
                FindTheKey.gameObject.SetActive(false);
                if (Input.GetKey(KeyCode.E))
                {
                    fadeConstans = 1;

                    LokedOpen.gameObject.SetActive(false);

                    OpenDoorSound.Play();

                    NoiseTV.SetActive(false);

                    anim.Play("Puerta_Abierta");

                }

            }
            else
            {
                LokedOpen.text = "Locked";
                if (Input.GetKey(KeyCode.E))
                {
                    LokedDoorSound.Play();
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        LokedOpen.gameObject.SetActive(false);
        FindTheKey.gameObject.SetActive(false);
    }

    private void Update()
    {
        Color newColor = fade.color;

        newColor.a += fadeConstans * Time.deltaTime;

        if(fade.color.a >= 2)
        {
            menuFin.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Player.SetActive(false);

        }

        fade.color = newColor;
    }
}
