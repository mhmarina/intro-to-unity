using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float muzzleVelocity;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F)) {
            GameObject bullet = GameObject.Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null) {
                Vector3 bulletForce = transform.forward * muzzleVelocity;
                rb.AddForce(bulletForce, ForceMode.Impulse);
            }
        }
    }
}
