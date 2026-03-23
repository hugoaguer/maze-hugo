using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 spawnPoint;
    public bool checkpointPassed = false;

    void Start()
    {
        spawnPoint = transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Respawn();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Checkpoint"))
        {
            spawnPoint = other.transform.position;
            checkpointPassed = true;
            other.gameObject.SetActive(false);
        }

        if (other.CompareTag("Goal") && checkpointPassed)
        {
            GameManager.instance.Win();
        }
    }

    void Update()
    {
        if (transform.position.y < -10)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        transform.position = spawnPoint;
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}