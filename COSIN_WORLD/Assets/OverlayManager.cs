using UnityEngine;
using System.Collections;

public class OverlayManager : MonoBehaviour {

    public GameObject prefab_Dot;
        GameObject inst_handler_dot;

    // Use this for initialization
    void Start () {

        ControlScript.onActivationCreateDot += SpawnCreateDot;
        ControlScript.onDeactivationDeleteDot += SpawnDeleteDot;
	
	}

    void SpawnCreateDot(GameObject gobj)
    {
        inst_handler_dot = Instantiate(prefab_Dot, Vector3.zero, Quaternion.identity)as GameObject;
        inst_handler_dot.transform.SetParent(transform, false);
        inst_handler_dot.GetComponent<followplayer>().player = gobj;

    }

     void SpawnDeleteDot(GameObject gobj)
    {
        followplayer[] fpdot = GameObject.FindObjectsOfType<followplayer>();
        foreach (followplayer fp in fpdot)
            if (fp.player == gobj)
            {
                Debug.Log("Found gobj");
                Destroy(fp.gameObject);
            }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
