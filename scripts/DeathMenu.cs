using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathMenu : MonoBehaviour {

    Animator anim;
    public Transform canvas;
    public Transform player;
    public Slider healthbar;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }



    void Update()
    {
        if (healthbar.value <=0)
        {
            anim.SetBool("IsDead", true);
            Pause();
        }
    }

    public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
            player.GetComponent<thirdpersonCamera>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
