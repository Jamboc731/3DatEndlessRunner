using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour {

    public Transform target;
    private Vector3 toSet;

	void Update () {

        toSet = target.transform.position;
        toSet.y = 2;
        toSet.x += 4;
        toSet.z = -10;

        this.transform.position = toSet;

	}
}
