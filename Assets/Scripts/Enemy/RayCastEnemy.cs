//using System.Collections;
//using System.Collections.Generic;
//using UnityEditor;
//using UnityEngine;

//public class RayCastEnemy : MonoBehaviour
//{
//    [SerializeField] private Transform m_raycastPoint;
//    [SerializeField] private float m_maxDistance;
//    [SerializeField] private LayerMask m_raycastLayer;

//    [SerializeField] private float force;
//    private void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            DoRaycast();
//        }
//    }
//    private void DoRaycast()
//    {
//        bool l_isHitting = Physics.Raycast(m_raycastPoint.position,m_raycastPoint.forward,out RaycastHit l_hit, m_maxDistance,m_raycastLayer);

//        if(l_isHitting)
//        {
//            if( l_isHitting && l_hit.rigidbody != null))
//                {
//                l_hit.rigidbody.AddForceAtPosition(transform.forward * force, l_hit.point,ForceMode.Impulse);
//            }
//        }
//    }
//    private void OnDrawGizmosSelected()
//    {
//        Gizmos.color = Color.magenta;
//        Gizmos.DrawLine(m_raycastPoint.position,m_raycastPoint.position + m_raycastPoint.forward * m_maxDistance );
//    }
//}
