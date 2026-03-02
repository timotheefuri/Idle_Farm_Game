using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float horizontal;
    public int Move_Speed = 20;
    public int Max_Move_Speed = 40;
    public Rigidbody2D rigidbody;
    public Collider2D collider;
    public PhysicsMaterial2D highfriction;
    public PhysicsMaterial2D lowfriction;
    public Vector2 direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

    }

    void FixedUpdate()
    {
        direction = new Vector2(horizontal, 0);
        rigidbody.AddForce(direction);

        if (Mathf.Abs(rigidbody.linearVelocity.x) > Max_Move_Speed)
        {
            rigidbody.linearVelocity = new Vector2(Mathf.Sign(Max_Move_Speed), 0);
        }




        if (Mathf.Abs(horizontal) < 0.01f && Mathf.Abs(rigidbody.linearVelocity.x) > 0.01f)
        {
            collider.sharedMaterial = highfriction;
        }
        else
        {
            collider.sharedMaterial = lowfriction;
        }




    }
}
