using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3 (0, 4, -8);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()

    // LateUpdate is called once per frame right after Update() called
    // ������� ���� � ������ Update(), � ������ ����� �� ��� � ������ LateUpdate()
    void LateUpdate()
    {
        // offset the camera behind the player by adding to the player's position
        // ������� ������ �� ������, �������� � ��������� ������
        // transform.position = player.transform.position + new Vector3( 0, 3, -7);
        transform.position = player.transform.position + offset;
        
    }
}
