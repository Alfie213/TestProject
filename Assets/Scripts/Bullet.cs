using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    private const float DESTROY_DELAY = 10f;
    private const float SPEED = 10f;

    private void Start()
    {
        GetComponent<Rigidbody>().velocity = -transform.forward * SPEED;
        Destroy(gameObject, DESTROY_DELAY);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
