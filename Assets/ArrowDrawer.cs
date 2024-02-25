using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class ArrowDrawer : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public Color lineColor = Color.white;
    public float arrowHeadSize = 0.2f;

    private void OnDrawGizmos()
    {
        if (startPoint != null && endPoint != null)
        {
            Debug.DrawLine(startPoint.position, endPoint.position, lineColor);

            // Draw arrowhead
            DrawArrowHead(startPoint.position, endPoint.position);
        }
    }

    private void DrawArrowHead(Vector3 start, Vector3 end)
    {
        // Calculate arrow direction
        Vector3 direction = (end - start).normalized;

        // Calculate positions of arrowhead vertices
        Vector3 arrowPoint1 = end - direction * arrowHeadSize + Quaternion.Euler(0, 160, 0) * direction * arrowHeadSize;
        Vector3 arrowPoint2 = end - direction * arrowHeadSize + Quaternion.Euler(0, -160, 0) * direction * arrowHeadSize;

        // Draw lines to form arrowhead
        Debug.DrawLine(end, arrowPoint1, lineColor);
        Debug.DrawLine(end, arrowPoint2, lineColor);
    }
}
