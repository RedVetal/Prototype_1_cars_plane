using UnityEngine;

public class VehicleMove : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //        Transform.Translate игнорирует физику
        //  Этот метод перемещает объект "насильно", не учитывая столкновения и массу Rigidbody.
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        // rb.AddForce(transform.forward * speed, ForceMode.Acceleration); // Плавное ускорение

    }
}
