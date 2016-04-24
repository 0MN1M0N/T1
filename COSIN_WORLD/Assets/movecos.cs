using UnityEngine;
using System.Collections;
using UnityEditor;
public class movecos : MonoBehaviour {

    [HideInInspector]
    public float x=0f;
    float y=-1f;

    
    void OnEnable()
    {
        ControlScript.CreateDot(gameObject);//call the event
    }
    void OnDisable()
    {
        ControlScript.DeleteDot(gameObject);//call the event
    }

    RectTransform rt,rt_parent;
	// Use this for initialization
	void Start () {

        rt = GetComponent<RectTransform>();
        rt_parent = rt.parent.GetComponent<RectTransform>();
	
	}
    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, Camera.main.transform.position);
        Gizmos.DrawSphere(Camera.main.transform.position, 1f);
    }
	// Update is called once per frame
	void FixedUpdate () {



        x += Time.fixedDeltaTime;
        x = Mathf.Clamp(x, 0f, 2f*Mathf.PI);

        y = Mathf.Sin(x)*Time.fixedDeltaTime*rt_parent.rect.height*16;// *Mathf.Rad2Deg;

        Debug.Log(rt_parent.rect.height+" "+rt_parent.rect.width);
        if (x >= 2f * Mathf.PI) x = 0f;
        //transform.localPosition = new Vector3(transform.localPosition.x,transform.localPosition.y, transform.localPosition.z+ y);

        rt.localPosition = new Vector3(x/ rt_parent.rect.width - 1f,y,0f );

    }
}
