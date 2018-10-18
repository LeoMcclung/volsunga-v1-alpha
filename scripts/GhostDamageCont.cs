using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GhostDamageCont : MonoBehaviour
{

    public Slider healthbar;
    Animator anim;
    public string opponent;

    void Start()
    {
        healthbar.maxValue = 100;
        healthbar.value = 100;
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != opponent) return;

        healthbar.value -= 20;

        if (healthbar.value <= 0)
            anim.SetBool("IsDead", true);
    }
}
