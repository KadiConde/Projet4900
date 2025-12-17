using UnityEngine;
using System.Collections;

// Gère la déformation de la balle lors des impacts.
[RequireComponent(typeof(Rigidbody))]
public class SoftBallDeformation : MonoBehaviour
{
    [Header("Réglages de déformation")]
    public float deformationAmount = 0.2f;   // combien on écrase
    public float impactThreshold = 1.0f;     // vitesse minimale pour déformer
    public float deformationTime = 0.1f;     // durée de l'écrasement
    public float recoveryTime = 0.2f;        // durée du retour

    private Vector3 originalScale;
    private bool isDeforming = false;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void OnCollisionEnter(Collision collision)
    {
        float speed = collision.relativeVelocity.magnitude;

        // On déforme seulement si l'impact est assez fort (ex: sol ou table)
        if (speed > impactThreshold && !isDeforming)
        {
            StartCoroutine(DeformAndRecover(collision.contacts[0].normal));
        }
    }

    IEnumerator DeformAndRecover(Vector3 collisionNormal)
    {
        isDeforming = true;

        // On aligne la déformation selon la normale du contact (option simple)
        Vector3 squash = originalScale;
        squash.y -= deformationAmount;
        squash.x += deformationAmount * 0.5f;
        squash.z += deformationAmount * 0.5f;

        float t = 0f;

        // Phase d'écrasement
        while (t < deformationTime)
        {
            t += Time.deltaTime;
            float k = t / deformationTime;
            transform.localScale = Vector3.Lerp(originalScale, squash, k);
            yield return null;
        }

        t = 0f;
        // Phase de retour
        while (t < recoveryTime)
        {
            t += Time.deltaTime;
            float k = t / recoveryTime;
            transform.localScale = Vector3.Lerp(squash, originalScale, k);
            yield return null;
        }

        transform.localScale = originalScale;
        isDeforming = false;
    }
}
