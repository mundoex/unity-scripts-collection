using UnityEngine;

public class RotatableObject : MonoBehaviour
{
    void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        float mouseWheel = Input.GetAxis("Mouse ScrollWheel");
        if (mouseWheel > 0)
        {
            gameObject.transform.Rotate(new Vector3(0, 90, 0));
        }
        if (mouseWheel < 0)
        {
            gameObject.transform.Rotate(new Vector3(0, -90, 0));
        }
    }
}
