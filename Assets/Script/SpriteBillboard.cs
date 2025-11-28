using UnityEngine;

public class SpriteBillboard : MonoBehaviour
{
    private Camera cam;

    void Awake()
    {
        cam = Camera.main;
    }

    void LateUpdate()
    {
        if (cam == null) return;

        // 카메라를 바라보되, y축 기울기 제거
        Vector3 dir = transform.position - cam.transform.position;
        dir.y = 0f;

        if (dir.sqrMagnitude < 0.0001f)
            return;

        transform.forward = dir;
    }
}
