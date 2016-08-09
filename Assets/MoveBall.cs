using UnityEngine;
using System.Collections;

public class MoveBall : MonoBehaviour {

    // change value in unity
    public float zSpeed = 10;

	// Use this for initialization
	void Start () {
        // log in unity console
        Debug.Log("Hello world");
	}
	
	// Update is called once per frame
	void Update () {
        // https://docs.unity3d.com/ScriptReference/Time-deltaTime.html
        // translate via time
        float translation = Time.deltaTime * zSpeed;
        transform.Translate(0, 0, translation);
	}
}
