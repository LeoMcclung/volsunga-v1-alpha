using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public Slider healthbar;

    public void LoadLevel (string name) {
		if(healthbar.value <= 0)
        {
            Application.LoadLevel("combat-test");
        }
	}
}
