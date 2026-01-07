using UnityEngine;
using UnityEngine.InputSystem;

public class CamRotate : MonoBehaviour
{
    //회전 속도 변수
    public float sensitivity = 5f;
    public GameObject Camera;
    Vector2 mouseInput;
    float mx = 0;
    float my = 0;
    
    // Update is called once per frame
    void Update()
    {

        //회전 값 변수에 마우스 입력값 누적
        mx += mouseInput.x * sensitivity;
        my += mouseInput.y * sensitivity;
        //마우스 상하 이동 회전 변수 값을 제한
        my=Mathf.Clamp(my, -90f, 90f);

        Camera.transform.eulerAngles=new Vector3(-my, mx, 0);
       
    }
    void OnLook(InputValue value)
    {
        mouseInput=value.Get<Vector2>();
    }
}
