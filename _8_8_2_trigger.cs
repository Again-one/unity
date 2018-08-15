using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _8_8_2_trigger : MonoBehaviour {
    private void OnTriggerEnter(Collider other) {
        Debug.Log("TriggerEnter");
        other.transform.position = new Vector2(0, 2);
    }
    private void OnTriggerStay(Collider other) {

        other.transform.position = new Vector2(0, other.transform.position.y + 0.01f);
        Debug.Log("被调用");
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
