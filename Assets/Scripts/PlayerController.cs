using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed = 15f;
    public float horizontalInput;
    public float verticalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // move the vehicle forward
        // transform.Translate(0, 0, 1f);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // при езде назад работает неправильно
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        
        // страйфы (можно добавить к повороту (для космо корабля))
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
