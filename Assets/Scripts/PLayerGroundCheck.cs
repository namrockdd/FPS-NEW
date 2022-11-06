using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerGroundCheck : MonoBehaviour
{
    PLayerController pLayerController;

    void Awake()
    {
        pLayerController = GetComponentInParent<PLayerController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == pLayerController.gameObject)
        {
            return;
        }
        pLayerController.SetGroundedState(true);
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject == pLayerController.gameObject)
        {
            return;
        }
        pLayerController.SetGroundedState(false);
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject == pLayerController.gameObject)
        {
            return;
        }
        pLayerController.SetGroundedState(true);
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.gameObject == pLayerController.gameObject)
        {
            return;
        }
        pLayerController.SetGroundedState(true);        
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        if(collisionInfo.gameObject == pLayerController.gameObject)
        {
            return;
        }
        pLayerController.SetGroundedState(false);        
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        if(collisionInfo.gameObject == pLayerController.gameObject)
        {
            return;
        }
        pLayerController.SetGroundedState(true);        
    }























}
