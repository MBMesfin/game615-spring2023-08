using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject watermelonBullet;
    public Transform bulletSpawn;
    public AudioSource audioSource;
    public AudioClip shootSound;
    public float bulletLifetime = 3f;

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
        GameObject bullet = Instantiate(watermelonBullet, bulletSpawn.position, bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward * 2000f);
        Destroy(bullet, bulletLifetime);
    }
    void PlayShootSound()
    {
        audioSource.PlayOneShot(shootSound);
    }
}
