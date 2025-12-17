using UnityEngine;

// Met le rigidbody en "sleep" quand la balle ne bouge presque plus.
[RequireComponent(typeof(Rigidbody))]
public class SoftBallAutoStop : MonoBehaviour
{
    public float sleepVelocity = 0.08f;   // seuil de vitesse
    public float sleepDelay = 0.7f;       // temps à vitesse basse avant arrêt

    private Rigidbody rb;
    private float timer = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // vitesse linéaire + rotation très faibles ?
        if (rb.linearVelocity.magnitude < sleepVelocity &&
            rb.angularVelocity.magnitude < sleepVelocity)
        {
            timer += Time.deltaTime;
            if (timer >= sleepDelay)
            {
                rb.Sleep();    // stop physique
                enabled = false; // plus besoin du script
            }
        }
        else
        {
            timer = 0f;
        }
    }
}
