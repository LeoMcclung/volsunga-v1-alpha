using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDamageCont : MonoBehaviour {

    public Slider healthbar;
    Animator anim;
    public string ghost;
    public string player;
    public string wolf;
    public string banshee;

    void Start()
    {
        healthbar.maxValue = 150;
        healthbar.value = 150;
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == player) return;

        if(other.gameObject.tag == ghost)
        {
            healthbar.value -= 2;
        } else if (other.gameObject.tag == wolf)
        {
            healthbar.value -= 20;
        } else if(other.gameObject.tag == banshee)
        {
            healthbar.value -= 20;
        }

        if (healthbar.value <= 0)
            anim.SetBool("IsDead", true);
    }
}
