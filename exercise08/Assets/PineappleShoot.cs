using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PineappleShoot : MonoBehaviour
{
    public Transform bulletSpawn;
    public AudioSource audioSource;
    public AudioClip shootSound;
    public float bulletLifetime = 3f;
    public float spinSpeed = 500f;
    public float bulletSpeed = 2000f;
    public bool selected = false;

    public GameObject pineappleBullet;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
            PlayShootSound();
        }

        //if (Input.GetKeyDown("s"))
        //{
        //    Shoot();
        //    PlayShootSound();
        //}
    }

    void Shoot()
    {


        //GameObject bullet1 = Instantiate(pineappleBullet, bulletSpawn.position + new Vector3(0, 0.1f, 0), bulletSpawn.rotation);
        //ParticleSystem trail1 = bullet1.GetComponentInChildren<ParticleSystem>();
        //trail1.Play();
        //bullet1.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward * bulletSpeed);
        //bullet1.GetComponent<Rigidbody>().AddTorque(bullet1.transform.up * spinSpeed);
        //Destroy(bullet1, bulletLifetime);

        GameObject bullet = Instantiate(pineappleBullet, bulletSpawn.position + new Vector3(0, 0.1f, 0), bulletSpawn.rotation);
        //ParticleSystem trail = bullet.GetComponentInChildren<ParticleSystem>();
        //trail.Play();
        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward * bulletSpeed);
        bullet.GetComponent<Rigidbody>().AddTorque(bullet.transform.up * spinSpeed);
        Destroy(bullet, bulletLifetime);
    }

    void PlayShootSound()
    {
        audioSource.PlayOneShot(shootSound);
    }

}
