using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    Vector2 moveInput;
    Vector3 dir;

    CharacterController cc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform cam = Camera.main.transform;
        Vector3 camForward= cam.forward;
        camForward.y = 0;
        camForward.Normalize();

        Vector3 camRight = cam.right;
        camRight.y = 0;
        camRight.Normalize();
        dir = camForward * moveInput.y + camRight * moveInput.x;


        cc.Move(dir * moveSpeed * Time.deltaTime);
    }
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
}
