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

        Debug.Log("OnTriggerEnter");
    }
}