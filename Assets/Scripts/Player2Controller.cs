using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed = 15f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal2"); // Стрелки
        float verticalInput = Input.GetAxis("Vertical2");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
