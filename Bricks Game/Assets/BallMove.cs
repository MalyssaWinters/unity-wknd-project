using UnityEngine;
using System.Collections;

public class BallMove : MonoBehaviour {

    private Rigidbody2D ballForce;
    public float force;

    // Use this for initialization
    void Start () {
        ballForce = GetComponent<Rigidbody2D>();
        ballForce.AddForce (new Vector2(1f, 0.5f) * Time.deltaTime * force);
	}
	
	// Update is called once per frame
	void Update () {
    }
}
