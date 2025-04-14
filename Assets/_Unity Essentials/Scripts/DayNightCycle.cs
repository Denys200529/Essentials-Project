using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Day-Night Cycle Settings")]
    [Tooltip("Time (in seconds) for a full day to pass.")]
    public float dayDuration = 60f; // 60 ������ = 1 ������ ���� ���-����

    private float rotationSpeed;

    void Start()
    {
        // ���������� �������� ��������� (360 ������� �� dayDuration ������)
        rotationSpeed = 360f / dayDuration;
    }

    void Update()
    {
        // �������� ����� ������� �� X, ��������� ����� ��� �� ����
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
