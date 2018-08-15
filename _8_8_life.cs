using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//重命名快捷键F2
public class _8_8_life : MonoBehaviour {
    void Awake() {
        //只要添加，不管组件节点是否被enable，只要被挂载就会被嗲用
        Debug.Log("Awake");
    }
    void OnEnable() {
        Debug.Log("OnEnable");
    }
    // Use this for initialization
    void Start () {
        //调试  Ctrl+alt+C调出控制台
        Debug.Log("Start");
        Debug.LogError("这是报错");
        Debug.LogWarning("这是警告");
        
       
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("这是update");
    }
    void FixedUpdate() {
        //基于物理时间的运算，基于固定时间来调用
        Debug.Log("FixedUpdate");

    }
    void LateUpdate() {

        Debug.Log("这是LateUpdate"+Time.deltaTime);
    }
    void OnGUI() {
        
        //在update后调用
    }
}
