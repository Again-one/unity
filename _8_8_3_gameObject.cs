using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _8_8_3_gameObject : MonoBehaviour {
    public Rigidbody rb;
    public _8_8_3_gameObject[] ga;
    Collider2D c2;
    // Use this for initialization
    void Start () {
        //gameObject.rigidbody已经过时了
        
        //Find和FindWithTag
        //在一般场合下
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnEnable() {
        rb = gameObject.GetComponent<Rigidbody>();
        ga = new _8_8_3_gameObject[3];
        ga[0] = gameObject.GetComponent<_8_8_3_gameObject>();
        ga[1] = gameObject.GetComponent<_8_8_3_gameObject>();
        ga[2] = gameObject.GetComponent<_8_8_3_gameObject>();
        c2 = GameObject.Find("py").GetComponent<Collider2D>();

    }
}
