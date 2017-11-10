using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLaunch : MonoBehaviour {
    public float force = 10;
    public Ball ball;

    private Camera cam;

    private void Start() {
        cam = Camera.main;
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Vector2 worldMousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            var dir = ((Vector2)ball.transform.position - worldMousePos).normalized;

            ball.Launch(force, dir);
        }
    }
}
