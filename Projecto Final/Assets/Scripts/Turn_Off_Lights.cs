using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Turn_Off_Lights : MonoBehaviour
{
    public Animator anim;
    public Light HouseLights;
    public GameObject EmissiveLights;
    public TextMeshProUGUI OffLightsText;
    public TextMeshProUGUI MenuText;
    public BoxCollider myCollider;
    public MeshCollider StartCollider;
    public AudioSource OffLightSound;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")

            OffLightsText.gameObject.SetActive(true);
        {
            if (Input.GetKey(KeyCode.E))
            {
                anim.Play("Tecla_Luz");

                HouseLights.enabled = (false);
                EmissiveLights.SetActive(false);
                OffLightsText.gameObject.SetActive(false);
                MenuText.gameObject.SetActive(false);
                Destroy(myCollider);
                Destroy(StartCollider);
                OffLightSound.Play();
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        OffLightsText.gameObject.SetActive(false);
    }
}
