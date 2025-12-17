using UnityEngine;

public class SoftBallKick : MonoBehaviour
{
    public Vector3 initialImpulse = new Vector3(2.5f, 0f, 0f); // vers +X

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(initialImpulse, ForceMode.Impulse);
    }
}
