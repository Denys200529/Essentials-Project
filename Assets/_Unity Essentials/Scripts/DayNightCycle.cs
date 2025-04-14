using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Day-Night Cycle Settings")]
    [Tooltip("Time (in seconds) for a full day to pass.")]
    public float dayDuration = 60f; // 60 секунд = 1 повний цикл дня-ночі

    private float rotationSpeed;

    void Start()
    {
        // Обчислюємо швидкість обертання (360 градусів за dayDuration секунд)
        rotationSpeed = 360f / dayDuration;
    }

    void Update()
    {
        // Обертаємо світло навколо осі X, створюючи ефект дня та ночі
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
