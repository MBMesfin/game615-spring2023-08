using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject watermelonBullet;
    public Transform bulletSpawn;
    public AudioSource audioSource;
    public AudioClip shootSound;
    public float bulletLifetime = 3f;
    public float spinSpeed = 500f;
    public float bulletSpeed = 2000f;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
            PlayShootSound();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(watermelonBullet, bulletSpawn.position + new Vector3(0, 0.1f, 0), bulletSpawn.rotation);
        ParticleSystem trail = bullet.GetComponentInChildren<ParticleSystem>();
        trail.Play();
        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward * bulletSpeed);
        bullet.GetComponent<Rigidbody>().AddTorque(bullet.transform.up * spinSpeed);
        Destroy(bullet, bulletLifetime);
    }
    void PlayShootSound()
    {
        audioSource.PlayOneShot(shootSound);
    }
}