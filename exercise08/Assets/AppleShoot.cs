using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleShoot : MonoBehaviour
{
    public Transform bulletSpawn;
    public AudioSource audioSource;
    public AudioClip shootSound;
    public float bulletLifetime = 3f;
    public float spinSpeed = 500f;
    public float bulletSpeed = 2000f;
    public bool selected = false;
    public GameObject appleBullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            Shoot();
            PlayShootSound();
        }
    }

    void Shoot()
    {

        GameObject bullet2 = Instantiate(appleBullet, bulletSpawn.position + new Vector3(0, 0.1f, 0), bulletSpawn.rotation);
        ParticleSystem trail2 = bullet2.GetComponentInChildren<ParticleSystem>();
        trail2.Play();
        bullet2.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward * bulletSpeed);
        bullet2.GetComponent<Rigidbody>().AddTorque(bullet2.transform.up * spinSpeed);
        Destroy(bullet2, bulletLifetime);
    }
    void PlayShootSound()
    {
        audioSource.PlayOneShot(shootSound);
    }
}
