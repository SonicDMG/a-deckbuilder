// 11/24/2025 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using System;
using UnityEditor;
using UnityEngine;

public class BoatRockingAnimation : MonoBehaviour
{
    public float rotationSpeed = 1.0f; // Speed of rocking
    public float rotationAngle = 5.0f; // Maximum angle of rocking

    private float time;

    void Update()
    {
        time += Time.deltaTime * rotationSpeed;
        float angle = Mathf.Sin(time) * rotationAngle;
        transform.localRotation = Quaternion.Euler(angle, 0, 0);
    }
}
