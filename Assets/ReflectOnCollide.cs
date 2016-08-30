using UnityEngine;
using System.Collections;

public class ReflectOnCollide : MonoBehaviour {

    //void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("OnCollisionEnter");
    //}

    void OnTriggerEnter(Collider collider)
    {
        // basic reflection
        var moveBall = GetComponent<MoveBall>();
        moveBall.zSpeed = -moveBall.zSpeed;

        // todo: make translation independent from public zSpeed
        // rather based on translation

        Debug.Log("OnTriggerEnter");
    }
}