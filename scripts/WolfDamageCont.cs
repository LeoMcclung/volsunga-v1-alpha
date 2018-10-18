using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WolfDamageCont : MonoBehaviour {

    public Slider healthbar;
    Animator anim;
    public string opponent;

    void Start()
    {
        healthbar.maxValue = 300;
        healthbar.value = 300;
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
