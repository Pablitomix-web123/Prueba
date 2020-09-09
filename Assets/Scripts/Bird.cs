using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour

{
    private bool isDead;
    public float upForce = 200f;
    //public GameControler GameControler;

    //var privadas
    private Rigidbody2D rb2D;
    private Animator anim;
    

    // Start is called before the first frame update
    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (isDead) return;
        
            if (Input.GetMouseButtonDown(0))
            {
                rb2D.velocity = Vector2.zero;
                rb2D.AddForce(Vector2.up* upForce);
            anim.SetTrigger("Flap");
            }
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        anim.SetTrigger("Die");
        GameControler.Instance.BirdDie();
        rb2D.velocity = Vector2.zero;
    }
}
