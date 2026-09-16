using UnityEngine;

public class Pistol : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 20f;
    public float bulletLifetime = 5f;
    public AudioClip clip;
    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void FireBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.Euler(bulletSpawnPoint.rotation.eulerAngles.x, 90, bulletSpawnPoint.rotation.eulerAngles.z));
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.linearVelocity = bulletSpawnPoint.forward * bulletSpeed;
        Destroy(bullet, bulletLifetime);
        audioSource.PlayOneShot(clip);
    }
}
