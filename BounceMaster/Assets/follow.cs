using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

    public Transform target;
    float offset = -1;

    void LateUpdate () {
        //UnityEngine.Debug.Log("is :" + gameObject.transform.position.y);
        if (gameObject.transform.position.y > 66.3) {
            Vector3 newPos1 = new Vector3(target.position.x, (target.position.y - offset), transform.position.z);
            transform.position = newPos1;
            return;
        }
        if (target.position.y < -1.05) {
            return;
        }
        Vector3 newPos = new Vector3(0, (target.position.y - offset), transform.position.z);
        transform.position = newPos;
    }
}