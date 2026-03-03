using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float horizontal;
    public int Move_Speed = 5;
    public Rigidbody2D rigidbody;
    public SpriteRenderer caracter_direction;
    public Animator anim;

    public bool is_Idle;
    public bool is_Running;

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

        if (horizontal == 1 )
        {
            rigidbody.linearVelocity = new Vector2(Move_Speed,0);
            anim.SetBool("is_Running",true);
            anim.SetBool("is_Idle", false);
            caracter_direction.flipX = true;
        }
        if (horizontal == -1)
        {
            rigidbody.linearVelocity = new Vector2(-Move_Speed, 0);
            anim.SetBool("is_Running", true);
            anim.SetBool("is_Idle", false);
            caracter_direction.flipX = false;
        }
        if (horizontal == 0)
        {
            rigidbody.linearVelocity = new Vector2(0, 0);
            anim.SetBool("is_Running", false);
            anim.SetBool("is_Idle", true);
        }

    }
}
