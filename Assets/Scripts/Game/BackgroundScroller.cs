using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public BoxCollider2D col;
    public Rigidbody2D rbody;

    private float widht;

    private float scroolSpeed = -5f;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider2D>();
        rbody = GetComponent<Rigidbody2D>();

        widht = col.size.x;
        col.enabled = false;

        rbody.velocity = new Vector2(scroolSpeed, 0);
        ResetObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -widht)
        {
            Vector2 resetPosition = new Vector2(widht * 2f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
            ResetObstacle();
        }
    }

    void ResetObstacle()
    {
        transform.GetChild(0).localPosition = new Vector3(0, Random.Range(3, -3), 0);
    }
}
