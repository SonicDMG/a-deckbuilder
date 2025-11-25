// 11/24/2025 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using UnityEngine;

[ExecuteInEditMode]
public class AlignCameraToPanel : MonoBehaviour
{
    public Camera mainCamera;
    public RectTransform panel;

    void Update()
    {
        AlignCameraToPanelPosition();
    }

    void AlignCameraToPanelPosition()
    {
        if (mainCamera == null || panel == null)
        {
            Debug.LogError("Main Camera or Panel is not assigned.");
            return;
        }

        // Reset camera rotation to ensure it's perpendicular to the panel
        mainCamera.transform.rotation = Quaternion.Euler(0, 0, 0);

        // Get the center position of the panel in world space
        Vector3 panelCenter = panel.transform.TransformPoint(panel.rect.center);

        // Set the camera position to match the panel's center position
        mainCamera.transform.position = new Vector3(panelCenter.x, panelCenter.y, -10); // Set Z to -10 to match the Canvas Plane Distance

        // Adjust the camera size to fit the panel
        Vector2 panelSize = panel.rect.size;
        float panelAspect = panelSize.x / panelSize.y;
        float screenAspect = (float)Screen.width / Screen.height;

        if (panelAspect > screenAspect)
        {
            mainCamera.orthographicSize = panelSize.y / 2;
        }
        else
        {
            mainCamera.orthographicSize = panelSize.x / (2 * screenAspect);
        }
    }
}