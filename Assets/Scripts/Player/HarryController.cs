using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class HarryController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Animator harryAnimator;
  //  private static readonly int Speed = 1;
    [SerializeField] private Camera m_camera;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private GameManager m_gameManager;   

   
    private void OnApplicationFocus(bool hasFocus)
    {
        Cursor.visible = !hasFocus;
        Cursor.lockState = hasFocus ? CursorLockMode.None : CursorLockMode.Confined;
    }

    void Update()
    {
        Move(GetMovementInput());
        Rotate(GetRotationInput());
    }

    private void Rotate(Vector2 p_scrollDelta)
    {
        transform.Rotate(Vector3.up, p_scrollDelta.x * rotationSpeed * Time.deltaTime, Space.Self);
    }

    private Vector2 GetRotationInput()
    {
        var l_mouseX = Input.GetAxis("Mouse X");
        var l_mouseY = Input.GetAxis("Mouse Y");
        return new Vector2(l_mouseX, l_mouseY);
    }

    private Vector3 GetMovementInput()
    {
        var l_horizontal = Input.GetAxis("Horizontal");
        var l_vertical = Input.GetAxis("Vertical");
        return new Vector3(l_horizontal, 0, l_vertical).normalized;
    }

    private void Move(Vector3 p_inputMovement)
    {
        var transform1 = transform;
        transform1.position += (p_inputMovement.z * transform1.forward + p_inputMovement.x * transform1.right) *
                               (speed * Time.deltaTime);
        if (p_inputMovement != new Vector3(0,0,0) )
        {
            harryAnimator.SetBool("isMoving",true);

        } else
        {
            harryAnimator.SetBool("isMoving", false);
        }

    }
}