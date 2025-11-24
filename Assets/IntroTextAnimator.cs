// 11/23/2025 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using UnityEngine;
using TMPro;

public class TextAnimator : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public float speed = 2f;
    public Color startColor = Color.white;
    public Color endColor = Color.yellow;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime * speed;
        textMeshPro.color = Color.Lerp(startColor, endColor, Mathf.PingPong(timer, 2));
    }
}