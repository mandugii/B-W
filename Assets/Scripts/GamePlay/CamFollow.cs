using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //카메라의 위치를 트랜스폼 타켓의 위치에 일치
        transform.position= target.position;
        
    }
}
