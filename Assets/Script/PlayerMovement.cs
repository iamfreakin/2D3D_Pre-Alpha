using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Camera cam;

    void Awake()
    {
        // 한 번만 찾아서 저장
        cam = Camera.main;
    }

    void Update()
    {
        // 입력
        float h = Input.GetAxisRaw("Horizontal"); // A(-1) ~ D(+1)
        float v = Input.GetAxisRaw("Vertical");   // S(-1) ~ W(+1)

        // 속도 계수
        float forwardSpeed = 0.8f; // W,S 조금 느리게
        float sideSpeed = 1.0f;    // A,D 기본 속도(혹은 1.1~1.2 가능)

        // 카메라 기준 방향
        Vector3 camForward = cam.transform.forward;
        camForward.y = 0f;
        camForward.Normalize();

        Vector3 camRight = cam.transform.right;
        camRight.y = 0f;
        camRight.Normalize();

        // 방향 + 속도 적용
        Vector3 moveDir =
            camForward * (v * forwardSpeed) +
            camRight   * (h * sideSpeed);

        moveDir.Normalize();

        // 이동!
        transform.position += moveDir * moveSpeed * Time.deltaTime;

    }
}
