using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Balanzacion : MonoBehaviour
{

    private DetetetetcCube m_RightDetector;
    private DetetetetcCube m_leftDetector;

    private Rigidbody m_currentPieza;

    private float m_fVelocity;

    private void Update()
    {
        Vector3 velocity = Vector3.zero;
        if(m_RightDetector.GetInside())
        {
            velocity.x += m_fVelocity * Time.deltaTime;
        }
        if (m_leftDetector.GetInside())
        {
            velocity.x -= m_fVelocity * Time.deltaTime;
        }

        m_currentPieza.velocity = velocity;
    }
}
