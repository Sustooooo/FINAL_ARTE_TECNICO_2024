using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV_On : MonoBehaviour
{
    public BoxCollider ColliderTV;

    public GameObject ScreenTV;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            ScreenTV.SetActive(true);
            Destroy(ColliderTV);
        }
    }
}
