using Cinemachine;
using UnityEngine;

public class SwitchConfineBoundingShape : MonoBehaviour
{
    void Start()
    {
        SwitchBoundingShape();
    }

    /// <summary>
    /// Switch the collider that cinemachine uses to define the edges of the scene
    /// </summary>
    private void SwitchBoundingShape()
    {
        // Get the polygon collider on the 'boundsconfiner' gameobject which is used by cinemachine to prevent the camera going beyond screen edges
        PolygonCollider2D polygonCollider2D = GameObject.FindGameObjectWithTag(Tags.BoundsConfiner).GetComponent<PolygonCollider2D>();

        CinemachineConfiner cinemachineConfiner = GetComponent<CinemachineConfiner>();

        cinemachineConfiner.m_BoundingShape2D = polygonCollider2D;

        // Since the confiner bounds have changed need to call this to clear the cache
        cinemachineConfiner.InvalidatePathCache();
    }
}
