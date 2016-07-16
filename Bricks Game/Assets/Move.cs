using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    Vector2 position;
    public float speed;

	// Use this for initialization
	void Start () {
        position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        float moveX = Input.GetAxis("Horizontal");
        position.x += moveX * Time.deltaTime * speed;
        position.x = Mathf.Clamp(position.x, -8f, +8f);
        transform.position = position;
	}
}
