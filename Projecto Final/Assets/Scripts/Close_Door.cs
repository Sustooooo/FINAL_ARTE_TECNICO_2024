using UnityEngine;

public class Close_Door : MonoBehaviour
{
    public Animator anim;
    public BoxCollider myCollider;
    public AudioSource DoorSlamSound;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.Play("Golpe_Puerta");
            Destroy(myCollider);
            DoorSlamSound.Play();
        }


    }
        
}
