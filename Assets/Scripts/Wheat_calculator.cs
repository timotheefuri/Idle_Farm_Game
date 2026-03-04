using UnityEngine;

public class Wheat_Calculator : MonoBehaviour
{
    public int farmer_amount = 1;
    public static int wheat_counter;
    private float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(wheat_counter);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;

        if (timer > 1f)
        {
            timer = 0f;
            Wheat();
        }
    }

    void Wheat()
    {
        wheat_counter += farmer_amount;
    }
}
