using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectHit : MonoBehaviour {

    public Slider healthbar;
    Animator anim;
    public string opponent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != opponent) return;

        healthbar.value -= 5;

        if (healthbar.value <= 0)
            anim.SetBool("IsDead", true);
    }

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update () {
		
	}
}
