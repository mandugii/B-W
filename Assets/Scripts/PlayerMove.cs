using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float moveSpeed = 5f;
    
    CharacterController cc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir=new Vector3(h,0,v);
        dir=dir.normalized;
        dir=Camera.main.transform.TransformDirection(dir);
        

        cc.Move(dir*moveSpeed*Time.deltaTime);
    }
}
