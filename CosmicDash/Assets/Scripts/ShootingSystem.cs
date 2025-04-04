using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingSystem : MonoBehaviour
{
    public GameObject projectile;
    public InputActionProperty input;

    public float fireRate = 0.25f;
    private float lastFireTime = 0f;

    public AudioSource fireSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        input.action.Enable();
    }

    private void FixedUpdate()
    {
        if (input.action.IsPressed() && Time.time > lastFireTime)
        {
            Fire();
            lastFireTime = Time.time + fireRate;
        }        
    }

    public void Fire()
    {
        Instantiate(projectile, transform.position, Quaternion.Euler(0, 90, 0));
        fireSound.Play();
    }
}