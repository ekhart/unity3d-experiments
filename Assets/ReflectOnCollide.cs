using UnityEngine;
using System.Collections;

public class ReflectOnCollide : MonoBehaviour {

    //void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("OnCollisionEnter");
    //}

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("OnTriggerEnter");
    }
}