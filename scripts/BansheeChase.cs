using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BansheeChase : MonoBehaviour {

    public Transform player;
    static Animator anim;
    public Slider healthbar;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        if (healthbar.value <= 0) return;

        Vector3 direction = player.position - this.transform.position;
        float angle = Vector3.Angle(direction, this.transform.forward);
        if (Vector3.Distance(player.position, this.transform.position) < 20 && angle < 120)
        {
            direction.y = 0;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
            anim.SetBool("IsIdle", false);
            if (direction.magnitude > 15)
            {
                this.transform.Translate(0, 0, 0.045f);
                anim.SetBool("IsRunning", true);
                anim.SetBool("IsAttacking", false);
            }
            else
            {
                anim.SetBool("IsAttacking", true);
                anim.SetBool("IsRunning", false);
            }
        }
        else
        {
            anim.SetBool("IsIdle", true);
            anim.SetBool("IsRunning", false);
            anim.SetBool("IsAttacking", false);
        }
    }
}
