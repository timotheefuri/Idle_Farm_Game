using UnityEngine;

public class Wheat_calculator : MonoBehaviour
{
    public static float wheat_counter = 0f;
    public static float wheat_counter_seconds = 0f;
    private float timer;
    public static float farmer_wheat = 0f;
    public static float tractor_wheat = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

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
            wheat_counter += farmer_wheat + tractor_wheat;
            wheat_counter_seconds = farmer_wheat + tractor_wheat;
        }        
    }
}
