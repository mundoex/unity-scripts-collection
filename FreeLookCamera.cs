using UnityEngine;

public class FreeLookCamera : MonoBehaviour
{
    private static float maxVerticalAngle = 80;
    private static float minVerticalAngle = 80;

    private float horizontalRotation = 0;
    private float verticalRotation = 0;

    public float sensitivityHorizontal = 60;
    public float sensitivityVertical = 50;
    public float movementSpeed = 15;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState=CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
        Movement();
    }

    void Rotation()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        horizontalRotation += x * sensitivityHorizontal * Time.deltaTime;
        verticalRotation -= y * sensitivityVertical * Time.deltaTime;

        verticalRotation = Mathf.Clamp(verticalRotation, -minVerticalAngle, maxVerticalAngle);

        transform.eulerAngles = new Vector3(verticalRotation, horizontalRotation, 0);
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * movementSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * movementSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * movementSpeed * Time.deltaTime;
        }
    }
}
