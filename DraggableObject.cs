using UnityEngine;

public class DraggableObject : MonoBehaviour
{
    private Vector3 mOffset;
    private float zWorldCoord;

    void OnMouseDrag()
    {
        transform.position = getWorldMousePosition() + mOffset;
    }

    private void OnMouseDown()
    {
        zWorldCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - getWorldMousePosition();
    }

    private Vector3 getWorldMousePosition()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = zWorldCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}
