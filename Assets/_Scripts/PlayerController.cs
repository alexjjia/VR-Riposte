using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 boundary = new Vector3(0, transform.position.y, 0);
        transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
        if(transform.position.y < 0)
        {
            transform.position = transform.position - boundary;
        }
    }
}
