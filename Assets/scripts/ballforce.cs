using UnityEngine;
using System.Collections;

public class ballforce : MonoBehaviour
{
    public AudioSource source;
    public AudioClip ballsound;
    private float Ballforce = 20;
    private float speed = 5;
    bool isPlay=false;
    void Awake()
    {
        source.GetComponent<AudioSource>();
    }
    void Update()
    {

        if (Input.GetKey("space") && isPlay == false)
        {
            transform.parent = null;
            isPlay = true;
            gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, Ballforce));        
        }
    }
    void OnCollisionEnter2D(Collision2D c)
    {
        source.PlayOneShot(ballsound);
        if (c.gameObject.name == "paddle")
        {
            float x = transform.position.x - c.transform.position.x;
            float y = transform.position.y - c.transform.position.y;
            Vector2 vec = new Vector2(x * 1, y * 3).normalized;
            GetComponent<Rigidbody2D>().velocity = vec * speed;

        }
        else if (c.gameObject.name == "top")
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -0.02f));
        }
    }
}
