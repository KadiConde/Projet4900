using UnityEngine;

// Fait osciller légèrement l'objet métallique lors d'un impact assez fort.
[RequireComponent(typeof(Rigidbody))]
public class MetalObjectShake : MonoBehaviour
{
    public float forceThreshold = 0.5f;
    public float torqueAmount = 0.5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        float speed = collision.relativeVelocity.magnitude;

        if (speed > forceThreshold)
        {
            // Petite rotation aléatoire
            Vector3 randomAxis = Random.onUnitSphere;
            rb.AddTorque(randomAxis * torqueAmount, ForceMode.Impulse);
        }
    }
}
