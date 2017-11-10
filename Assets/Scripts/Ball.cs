using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public float dist2stop = 2;
    private Rigidbody2D rb2d;
    private Vector2 startPos;
    private bool stoped = false;

    private void Start() {
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void Launch(float force, Vector2 dir) {
        stoped = false;
        startPos = rb2d.position;
        rb2d.AddForce(dir * force, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        var dist = Vector2.Distance(startPos, rb2d.position);
        print(dist);
        if (collision.collider.CompareTag("Ball") && dist > dist2stop && !stoped) {
            print("stoooop");
            //rb2d.velocity = Vector2.zero;
        }

        if(collision.collider.CompareTag("Ball"))
            stoped = true;
    }
}
