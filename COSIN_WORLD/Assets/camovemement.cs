using UnityEngine;
using System.Collections;

public class camovemement : MonoBehaviour {

    float t = 0;
    Vector3 startpos;
	// Use this for initialization
	void Start () {
        startpos = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow))Interp(0.02f,startpos);
        
            if (Input.GetKey(KeyCode.RightArrow)) Interp(0.02f,Vector3.one);




    }

        void Interp(float t,Vector3 target)
        {

        t = Mathf.Clamp(t, 0f, 1f);
        transform.position = Vector3.Lerp(transform.position,target, t);
        

            
        }

}
