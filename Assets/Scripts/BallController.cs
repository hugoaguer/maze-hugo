using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 spawnPoint;

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
        if (other.CompareTag("Goal"))
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
        GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}