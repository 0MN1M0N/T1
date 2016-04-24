using UnityEngine;
using System.Collections;

public class lookatscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.rotation = Quaternion.LookRotation(Camera.main.transform.position - transform.position,Vector3.up);
        //transform.LookAt(Camera.main.transform);

        //transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward,
           // Camera.main.transform.rotation * Vector3.up);

    }
}
