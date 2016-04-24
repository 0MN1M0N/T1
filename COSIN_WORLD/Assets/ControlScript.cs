using UnityEngine;
using System.Collections;

public class ControlScript : MonoBehaviour {

    public Transform c;
    Transform canvasToDisable;
	// Use this for initialization
	void Start () {
        canvasToDisable = transform.GetChild(0);
	}

    //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    public delegate void SpawnOverlayHandler(GameObject gobj);

    public static SpawnOverlayHandler onActivationCreateDot;
    public static SpawnOverlayHandler onDeactivationDeleteDot;

    public static void CreateDot(GameObject gobj)
    {
        if(onActivationCreateDot !=null)
        {
            onActivationCreateDot(gobj);
        }
    }

    public static void DeleteDot(GameObject gobj)
    {
        if (onDeactivationDeleteDot != null)
        {
            onDeactivationDeleteDot(gobj);
        }
    }
    //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

    // Update is called once per frame
    void Update ()
    {

if(Input.GetKey(KeyCode.F))
        {
            transform.rotation = Quaternion.AngleAxis(transform.eulerAngles.y + 3f, Vector3.up);
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.rotation = Quaternion.AngleAxis(transform.eulerAngles.y - 3f, Vector3.up);
        }

    }



    public void EnableDisable()
    {
        canvasToDisable.gameObject.SetActive(!canvasToDisable.gameObject.activeInHierarchy);
        c.gameObject.GetComponent<movecos>().x = 0f;
    }
}
