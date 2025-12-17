using UnityEngine;

// Fait réagir légèrement l'objet métallique lors d'un impact.
[RequireComponent(typeof(Rigidbody))]
public class MetalObjectOscillation : MonoBehaviour
{
    public float forceThreshold = 0.3f; // impact minimal
    public float torqueAmount = 0.5f;   // intensité de l'oscillation

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        float impactSpeed = collision.relativeVelocity.magnitude;

        if (impactSpeed > forceThreshold)
        {
            // Ajouter une petite rotation aléatoire
            Vector3 randomAxis = Random.onUnitSphere;
            rb.AddTorque(randomAxis * torqueAmount, ForceMode.Impulse);
        }
    }
}
