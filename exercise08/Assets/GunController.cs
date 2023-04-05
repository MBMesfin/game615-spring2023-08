using Unity.VisualScripting;
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
    public bool selected = false; 

    //public GameObject pineappleBullet;
   // public GameObject appleBullet;

    public string gunName;

    GameManager gm;

    void Start()
    {
        //GameObject gmObj = GameObject.Find("GameManagerObject");
        //gm = gmObj.GetComponent<GameManager>();
    }

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


        //if (gm.selectedUnit != null)
        //{
            GameObject bullet = Instantiate(watermelonBullet, bulletSpawn.position + new Vector3(0, 0.1f, 0), bulletSpawn.rotation);
            ParticleSystem trail = bullet.GetComponentInChildren<ParticleSystem>();
            trail.Play();
            bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward * bulletSpeed);
            bullet.GetComponent<Rigidbody>().AddTorque(bullet.transform.up * spinSpeed);
            Destroy(bullet, bulletLifetime);

        //gm.uiPanel.SetTrigger("uiPanelOn");
        //}

    }
    void PlayShootSound()
    {
        audioSource.PlayOneShot(shootSound);
    }

    //private void OnMouseDown()
    //{

    //    if (gm.selectedUnit != null)
    //    {
    //        // if we're here, something was already selected!
    //        // 1. Deselect it
    //        gm.selectedUnit.selected = false;
    //        //gm.selectedUnit.bodyRend.material.color = gm.selectedUnit.defaultColor;
    //    }
    //    // 2. Select me!
    //    selected = true;
    //   // bodyRend.material.color = selectedColor;

    //    if (gm.selectedUnit == null)
    //    {
    //        gm.uiPanel.SetTrigger("uiPanelOn");
    //    }

    //    gm.selectedUnit = this;


    //   // gm.theName.text = gunName;
    //}
}