
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public float rotationSpeed = 120f;

    void Update()
    {
        float x = 0;
        float z = 0;

        if (Input.GetKey(KeyCode.Z)) x = 1;
        if (Input.GetKey(KeyCode.S)) x = -1;
        if (Input.GetKey(KeyCode.Q)) z = -1;
        if (Input.GetKey(KeyCode.D)) z = 1;

        transform.Rotate(new Vector3(x, 0, z) * rotationSpeed * Time.deltaTime);
    }
}
