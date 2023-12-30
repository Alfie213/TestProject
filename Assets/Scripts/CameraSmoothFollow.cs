using UnityEngine;

public class CameraSmoothFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float smoothSpeed;
    [SerializeField] private Vector3 offset;

    private void Awake()
    {
        if (target is null)
        {
            Debug.LogWarning("Target is null.");
        }
    }

    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // transform.LookAt(target);
    }
}
