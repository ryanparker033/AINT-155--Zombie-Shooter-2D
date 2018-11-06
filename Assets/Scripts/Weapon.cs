using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public GameObject bulletprefab;
    public Transform bulletspawn;
    public float fireTime = 0.5f;

    private bool isFiring = false;
    
    private void SetFiring() {
        isFiring = false;

    }

    private void Fire() {
        isFiring = true;
        Instantiate(bulletprefab, bulletspawn.position, bulletspawn.rotation);

        if (GetComponent<AudioSource>() != null) {
            GetComponent<AudioSource>().Play();

        }
        Invoke("SetFiring", fireTime);
    }
    
	private void Update () {
		if (Input.GetMouseButton(0))
        {
            if (!isFiring) {
                Fire();
            }
        }
	}
}
