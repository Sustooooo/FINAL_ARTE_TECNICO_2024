using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pick_Key : MonoBehaviour
{
    public TextMeshProUGUI PickUpText;
    public BoxCollider TriggerTV;
    public AudioSource KeySound;
    public AudioSource KnockingDoorSound;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PickUpText.gameObject.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                gameObject.SetActive(false);

                PlayerController playerController = other.GetComponent<PlayerController>();

                playerController.hasKey = true;

                TriggerTV.gameObject.SetActive(true);

                PickUpText.gameObject.SetActive(false);

                KeySound.Play();

                KnockingDoorSound.Play();
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickUpText.gameObject.SetActive(false);
    }


}
