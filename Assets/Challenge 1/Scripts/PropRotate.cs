using UnityEngine;

public class PropRotate : MonoBehaviour
{
    public float propSpeed = 20.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, propSpeed);
    }
}
