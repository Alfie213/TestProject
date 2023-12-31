using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private Transform spawnParent;
    [SerializeField] private GameObject bulletPrefab;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FireBullet();
        }
    }

    private void FireBullet()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation, spawnParent);
    }
}
