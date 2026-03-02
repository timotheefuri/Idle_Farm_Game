using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float horizontal;
    public int Move_Speed = 5;
    public int Max_Move_Speed = 2;
    public Rigidbody2D rigidbody;
    public Collider2D collider;
    public PhysicsMaterial2D highfriction;
    public PhysicsMaterial2D lowfriction;
    private Vector2 direction;

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


        if (Mathf.Abs(rigidbody.linearVelocity.x) > Max_Move_Speed)        // max speed
        {
            if (horizontal == 1)
            {
                rigidbody.linearVelocity = new Vector2(Max_Move_Speed, 0);
            }
            if (horizontal == -1)
            {
                rigidbody.linearVelocity = new Vector2(-Max_Move_Speed, 0);
            }
            else
            {
                direction = new Vector2(horizontal, 0) * Move_Speed;
            }
        }
        else   // mouvement
        {
        direction = new Vector2(horizontal, 0) * Move_Speed*Move_Speed;
        }

        rigidbody.AddForce(direction);


        if (Mathf.Abs(horizontal) < 0.01f && Mathf.Abs(rigidbody.linearVelocity.x) > 0.01f)
        {
            collider.sharedMaterial = highfriction;
        }
        else
        {
            collider.sharedMaterial = lowfriction;
        }

    }
    void OnGUI()
    {
        float speed = rigidbody.linearVelocity.magnitude;
        GUI.Label(new Rect(10, 10, 200, 20), "Speed: " + speed.ToString("F2"));
    }
}
