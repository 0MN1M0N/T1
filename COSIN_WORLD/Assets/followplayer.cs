using UnityEngine;
using System.Collections;

public class followplayer : MonoBehaviour {

    public GameObject player = null;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

        if(player)

        transform.position = Camera.main.WorldToScreenPoint(player.transform.position);

       // transform.position = Vector3.
	
	}
}
