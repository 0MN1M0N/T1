using UnityEngine;
using System.Collections;

public class slerping : MonoBehaviour {

    public Transform[] tform;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector3.Lerp(tform[0].position, tform[1].position, Time.time);
        transform.rotation = Quaternion.Lerp(tform[0].rotation, tform[1].rotation, Time.time);

    }
}
