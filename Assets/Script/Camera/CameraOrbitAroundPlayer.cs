using UnityEngine;

public class CameraOrbitAroundPlayer : MonoBehaviour
{
    public Transform target;            // 플레이어
    public float followDelay = 0.25f;   // 플레이어 따라잡는 딜레이
    public float moveSmooth = 5f;       // 카메라 자체 움직임 부드러움
    public float rotateSnap = 45f;      // Q/E 회전
    public float rotateSmooth = 10f;    // 회전 부드러움
    public float heightLookOffset = 1f; // 카메라가 바라볼 높이

    private Vector3 followPoint;        // 지연된 기준점
    private Vector3 followVelocity;     // SmoothDamp 내부 상태

    private float currentAngleY = 0f;
    private float targetAngleY = 0f;

    private Vector3 initialOffset;      // 카메라-기준점 간 거리

    void Start()
    {
        if (target == null)
        {
            Debug.LogWarning("CameraOrbitAroundPlayer: target이 설정되지 않았습니다.");
            enabled = false;
            return;
        }

        initialOffset = transform.position - target.position;

        followPoint = target.position;

        currentAngleY = 0f;
        targetAngleY = 0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            targetAngleY -= rotateSnap;

        if (Input.GetKeyDown(KeyCode.E))
            targetAngleY += rotateSnap;
    }

    void LateUpdate()
    {
        if (target == null) return;

        // 1) 회전 부드럽게 보간
        currentAngleY = Mathf.LerpAngle(
            currentAngleY,
            targetAngleY,
            Time.deltaTime * rotateSmooth
        );

        Quaternion rot = Quaternion.Euler(0f, currentAngleY, 0f);
        Vector3 rotatedOffset = rot * initialOffset;

        // 2) followPoint는 SmoothDamp로 타겟을 늦게 따라감
        followPoint = Vector3.SmoothDamp(
            followPoint,
            target.position,
            ref followVelocity,
            followDelay
        );

        // 3) 카메라 목표 위치
        Vector3 desiredPos = followPoint + rotatedOffset;

        // 4) 카메라가 목표 위치를 Lerp로 부드럽게 따라감 (원래 있던 느낌!)
        transform.position = Vector3.Lerp(
            transform.position,
            desiredPos,
            Time.deltaTime * moveSmooth
        );

        // 5) 카메라가 followPoint를 바라봄
        Vector3 lookTarget = followPoint + Vector3.up * heightLookOffset;
        transform.rotation = Quaternion.LookRotation(lookTarget - transform.position);
    }
}
