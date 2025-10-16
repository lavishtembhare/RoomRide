using UnityEngine;

[ExecuteAlways]
public class DayNightCycle : MonoBehaviour
{
    [Header("Day Cycle Settings")]
    [Tooltip("Duration of one full day (in real-time seconds).")]
    public float dayDurationInSeconds = 120f;

    [Tooltip("Axis around which the light rotates (default: X-axis).")]
    public Vector3 rotationAxis = Vector3.right;

    [Tooltip("Start time of the day (0 = midnight, 0.25 = 6 AM, 0.5 = noon, etc.)")]
    [Range(0f, 1f)] public float startTime = 0.25f;

    [Header("Runtime Info (Read-Only)")]
    [Range(0f, 1f)] public float currentTime = 0f;

    void Start()
    {
        currentTime = startTime;
    }

    void Update()
    {
        if (dayDurationInSeconds <= 0f) return;

        // Progress time
        currentTime += Time.deltaTime / dayDurationInSeconds;
        if (currentTime >= 1f)
            currentTime -= 1f; // Loop back to start of the day

        // Rotate light
        float rotationAngle = currentTime * 360f;
        transform.localRotation = Quaternion.Euler(rotationAngle, 0f, 0f);
    }
}
