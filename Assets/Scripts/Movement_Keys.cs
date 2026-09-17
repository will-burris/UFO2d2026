using UnityEngine;

public class Movement_Keys : MonoBehaviour
{
    public float speed = 20.0f;

    private Rigidbody2D rb2d;

    private Vector3 startingScale;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        startingScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Vector2.zero;

        //Inputs the "Vertical" and "Horizontal" with their own directions on the x and y axis.
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        //Helps Unity with Microsoft to figure our which Vector2 is used.
        if(direction != Vector2.zero){
            direction.Normalize();
        }else{
            rb2d.linearVelocity *= 0.9f;
        }

        //The sprites rigidbody 2D adds force in direction multiplied by the speed variable.
        rb2d.AddForce(direction * speed);

        if(transform.localScale.x > startingScale.x){
            transform.localScale -= new Vector3(Time.deltaTime , Time.deltaTime , Time.deltaTime);
        }
        if(transform.localScale.x < startingScale.x){
            transform.localScale = startingScale;
        }
    }

    void OnCollisionEnter2D(Collision2D _collision){
        transform.localScale = startingScale * 1.2f;
    }
}