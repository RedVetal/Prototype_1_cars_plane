
//���������� ��� ������ �� ������ ������ � Hierarchy
//    ��� 
//    ChaseCamera: ������ ������ FollowPlayer �� ���� ������
//    DriverCamera: ������ ������ � �������� �������� ������ (�������� � � �������� ������ ������� ������).

//������ ��� ����� ���������(child) � ����� ��������� � �������.
//�������� ���� ������ (CameraSwitcher) �� ������  �� �����.
//� ���������� � ���������� CameraSwitcher �������� ��� ����:
//Chase Camera � �������� ���� ���� ������ ������ ������.
//Driver Camera � ���� ������ �� ������.


using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    // ������ �� ������, ������� ������� �� ������� (������ ��������� ���� ���� � ������)
    public Camera chaseCamera;

    // ������ �� ������ �� ������� ���� (����������� ������ ������ � ��� ����� �� �� ����)
    public Camera driverCamera;

    // � ���� ����� �� ����� �������, ����� ������ ������ �������.
    // true � ������� chaseCamera (��� �����), false � ������� driverCamera (�� ������� ����)
    private bool isChaseView = true;

    // ����� Start() ���������� ���� ��� ��� ������� ����
    void Start()
    {
        // ������������� ��������� ��� ������ (�� ��������� � chaseCamera)
        SetCameraView(isChaseView);
    }

    // ����� Update() ���������� ������ ����
    void Update()
    {
        // ���������, ����� �� ����� ������� "C" (� ����������)
        if (Input.GetKeyDown(KeyCode.C))
        {
            // ������ �������� �����: ���� ���� true, ������ false, � ��������
            isChaseView = !isChaseView;

            // �������� �����, ������� �������� ���� ������ � ��������� ������
            SetCameraView(isChaseView);
        }
    }

    // ���� ����� �������� ���� ������ � ��������� ������,
    // � ����������� �� �������� chaseView
    void SetCameraView(bool chaseView)
    {
        // ���� chaseView == true:
        // - �������� chaseCamera
        // - ��������� driverCamera
        // ���� chaseView == false � ��������
        chaseCamera.enabled = chaseView;
        driverCamera.enabled = !chaseView;

        // �������������: ����� ���������/�������� AudioListener
        // (���� AudioListener ����� � ������ ������ � �����, ����� ��� ������� ������ ����)
        AudioListener chaseListener = chaseCamera.GetComponent<AudioListener>();
        AudioListener driverListener = driverCamera.GetComponent<AudioListener>();

        if (chaseListener != null) chaseListener.enabled = chaseView;
        if (driverListener != null) driverListener.enabled = !chaseView;
    }
}


///////////////////////////////////////////////////////////////
///

//using UnityEngine;

//public class CameraSwitcher : MonoBehaviour
//{
//    public Camera firstPersonCamera;
//    public Camera thirdPersonCamera;
//    public KeyCode switchKey = KeyCode.C;

//    void Start()
//    {
//        // �������� ������ ������, ��������� ������
//        firstPersonCamera.enabled = true;
//        thirdPersonCamera.enabled = false;
//    }

//    void Update()
//    {
//        if (Input.GetKeyDown(switchKey))
//        {
//            // ����������� ������
//            firstPersonCamera.enabled = !firstPersonCamera.enabled;
//            thirdPersonCamera.enabled = !thirdPersonCamera.enabled;
//        }
//    }
//}


///////////////////////////////////////////////////////////////////

//using UnityEngine;

//public class CameraSwitcher : MonoBehaviour
//{
//    // ������, ����� �������� �������������
//    public Camera firstPersonCamera;
//    public Camera thirdPersonCamera;

//    // ������� ��� ������������
//    public KeyCode switchKey = KeyCode.C;

//    void Start()
//    {
//        // �������� ��� �� ������� ����, ��������� ��� �����
//        SetActiveCamera(firstPersonCamera, thirdPersonCamera);
//    }

//    void Update()
//    {
//        if (Input.GetKeyDown(switchKey))
//        {
//            // ���� ������ ������� ������ ������ � �������� ������, � ��������
//            bool isFirstPersonActive = firstPersonCamera.enabled;
//            SetActiveCamera(isFirstPersonActive ? thirdPersonCamera : firstPersonCamera,
//                            isFirstPersonActive ? firstPersonCamera : thirdPersonCamera);
//        }
//    }

//    // �������� ���� ������ � ��������� ������, �������/�������� ����� AudioListener
//    void SetActiveCamera(Camera camToEnable, Camera camToDisable)
//    {
//        // �������� ������ ������ � � AudioListener
//        camToEnable.enabled = true;
//        if (camToEnable.TryGetComponent(out AudioListener listenerOn))
//            listenerOn.enabled = true;

//        // ��������� ������ ������ � � AudioListener
//        camToDisable.enabled = false;
//        if (camToDisable.TryGetComponent(out AudioListener listenerOff))
//            listenerOff.enabled = false;
//    }
//}


