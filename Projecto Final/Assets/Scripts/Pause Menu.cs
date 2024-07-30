using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject menuPausa;
    [SerializeField] private GameObject menuMain;
    
    [SerializeField] private AudioSource[] sources;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 1)
            Pause();
        else if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 0)
            Resume();

    }
    public void Pause()
    {
        menuPausa.SetActive(true);
        menuMain.SetActive(false);

        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 0;

        for (int i = 0; i < sources.Length; i++)
        {
            sources[i].Pause();
        }

    }
    public void Resume()
    {
        menuPausa.SetActive(false);
        menuMain.SetActive(true);

        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;

        for (int i = 0; i < sources.Length; i++)
        {
            sources[i].Play();
        }
    }


}
