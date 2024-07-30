using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Pick_Up_Flashlight : MonoBehaviour
{
    public GameObject FlashlightOnPlayer;
    public GameObject PickUpText;
    public AudioSource FlashlightSound;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PickUpText.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                gameObject.SetActive(false);

                FlashlightOnPlayer.SetActive(true);

                PickUpText.SetActive(false);

                FlashlightSound.Play();
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickUpText.SetActive(false);
    }
}
