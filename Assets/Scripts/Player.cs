using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed;

	void Update () {

        this.transform.Translate (new Vector3(1, 0, 0) * Time.deltaTime * speed);

	}
}
