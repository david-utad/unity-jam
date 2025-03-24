using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class monkeyMovement : MonoBehaviour
{
    private CharacterController m_characterController;

    [SerializeField] private float m_fVelocity;

    private void Awake()
    {
        m_characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;
        if (Input.GetKey(KeyCode.D)) 
        {
            Debug.Log("se mueve");
            movement.x += m_fVelocity * Time.deltaTime; 
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement.x -= m_fVelocity * Time.deltaTime;
        }
        m_characterController.Move(movement);
    }

    
}
