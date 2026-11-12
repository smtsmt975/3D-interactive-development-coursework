
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    private Rigidbody rb;
    private Camera cam;

    private Vector3 offset;
    private float mouseDepth;
    private bool isDragging = false;

    private RigidbodyConstraints originalConstraints;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;

        originalConstraints = rb.constraints;
    }

    void OnMouseDown()
    {
        mouseDepth = cam.WorldToScreenPoint(transform.position).z;

        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = mouseDepth;

        offset = transform.position -
                 cam.ScreenToWorldPoint(mousePosition);

        isDragging = true;

        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        rb.constraints = originalConstraints |
                         RigidbodyConstraints.FreezeRotation;
    }

    void FixedUpdate()
    {
        if (isDragging)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = mouseDepth;

            Vector3 targetPosition =
                cam.ScreenToWorldPoint(mousePosition) + offset;

            rb.MovePosition(targetPosition);
        }
    }

    void OnMouseUp()
    {
        isDragging = false;

        rb.constraints = originalConstraints;
    }
}
