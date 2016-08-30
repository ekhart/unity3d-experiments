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
        //        var moveBall = GetComponent<MoveBall>();
        //        moveBall.zSpeed = -moveBall.zSpeed;

        // todo: make translation independent from public zSpeed
        // rather based on translation
        //        transform.TransformDirection(0, 0, transform.position.z);
        
        // not working
        //var pos = transform.position;
        //transform.position.Set(pos.x, pos.y, -pos.z);

        Debug.Log("OnTriggerEnter");
    }
}