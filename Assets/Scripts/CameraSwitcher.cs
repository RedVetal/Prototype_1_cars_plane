
//Перетащите обе камеры на объект машины в Hierarchy
//    или 
//    ChaseCamera: Оставь скрипт FollowPlayer на этой камере
//    DriverCamera: Просто сделай её дочерним объектом машины (перетащи её в иерархии внутрь объекта машины).

//Теперь они стали дочерними(child) и будут двигаться с машиной.
//Перетащи этот скрипт (CameraSwitcher) на машину  на сцене.
//В инспекторе у компонента CameraSwitcher появятся два поля:
//Chase Camera — перетащи сюда свою камеру позади машины.
//Driver Camera — сюда камеру из кабины.


using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    // Ссылка на камеру, которая следует за машиной (обычно находится чуть выше и позади)
    public Camera chaseCamera;

    // Ссылка на камеру от первого лица (расположена внутри машины — как будто ты за рулём)
    public Camera driverCamera;

    // В этом флаге мы будем хранить, какая камера сейчас активна.
    // true — активна chaseCamera (вид сзади), false — активна driverCamera (от первого лица)
    private bool isChaseView = true;

    // Метод Start() вызывается один раз при запуске игры
    void Start()
    {
        // Устанавливаем начальный вид камеры (по умолчанию — chaseCamera)
        SetCameraView(isChaseView);
    }

    // Метод Update() вызывается каждый кадр
    void Update()
    {
        // Проверяем, нажал ли игрок клавишу "C" (с клавиатуры)
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Меняем значение флага: если было true, станет false, и наоборот
            isChaseView = !isChaseView;

            // Вызываем метод, который включает одну камеру и отключает другую
            SetCameraView(isChaseView);
        }
    }

    // Этот метод включает одну камеру и отключает другую,
    // в зависимости от значения chaseView
    void SetCameraView(bool chaseView)
    {
        // Если chaseView == true:
        // - включаем chaseCamera
        // - выключаем driverCamera
        // Если chaseView == false — наоборот
        chaseCamera.enabled = chaseView;
        driverCamera.enabled = !chaseView;

        // Дополнительно: можно отключать/включать AudioListener
        // (если AudioListener стоит у каждой камеры — нужно, чтобы был активен только один)
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
//        // Включаем первую камеру, выключаем вторую
//        firstPersonCamera.enabled = true;
//        thirdPersonCamera.enabled = false;
//    }

//    void Update()
//    {
//        if (Input.GetKeyDown(switchKey))
//        {
//            // Переключаем камеры
//            firstPersonCamera.enabled = !firstPersonCamera.enabled;
//            thirdPersonCamera.enabled = !thirdPersonCamera.enabled;
//        }
//    }
//}


///////////////////////////////////////////////////////////////////

//using UnityEngine;

//public class CameraSwitcher : MonoBehaviour
//{
//    // Камеры, между которыми переключаемся
//    public Camera firstPersonCamera;
//    public Camera thirdPersonCamera;

//    // Клавиша для переключения
//    public KeyCode switchKey = KeyCode.C;

//    void Start()
//    {
//        // Включаем вид от первого лица, отключаем вид сзади
//        SetActiveCamera(firstPersonCamera, thirdPersonCamera);
//    }

//    void Update()
//    {
//        if (Input.GetKeyDown(switchKey))
//        {
//            // Если сейчас активна первая камера — включаем вторую, и наоборот
//            bool isFirstPersonActive = firstPersonCamera.enabled;
//            SetActiveCamera(isFirstPersonActive ? thirdPersonCamera : firstPersonCamera,
//                            isFirstPersonActive ? firstPersonCamera : thirdPersonCamera);
//        }
//    }

//    // Включает одну камеру и выключает другую, включая/выключая также AudioListener
//    void SetActiveCamera(Camera camToEnable, Camera camToDisable)
//    {
//        // Включаем нужную камеру и её AudioListener
//        camToEnable.enabled = true;
//        if (camToEnable.TryGetComponent(out AudioListener listenerOn))
//            listenerOn.enabled = true;

//        // Отключаем другую камеру и её AudioListener
//        camToDisable.enabled = false;
//        if (camToDisable.TryGetComponent(out AudioListener listenerOff))
//            listenerOff.enabled = false;
//    }
//}


