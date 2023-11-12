using UnityEngine;

public class ThridPersonCamera : MonoBehaviour
{
    [field: SerializeField] private Transform target;
    [field: SerializeField] private float rotationSpeed = 5f;
    [field: SerializeField] private float distance = 5f;

    //private float mouseY = 0f;
    private float mouseX = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        //mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        //mouseY = Mathf.Clamp(mouseY, -30f, 30f);
    }

    void LateUpdate()
    {
        Vector3 direction = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(0, mouseX, 0);
        transform.position = target.position + rotation * direction;
        transform.LookAt(target.position);
    }
}