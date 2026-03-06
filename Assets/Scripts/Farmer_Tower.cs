using UnityEngine;

public class Farmer_Tower : MonoBehaviour
{
    public int farmer_amount = 1;
    private float timer;

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

        if (farmer_amount >= 1)
        {
            timer += Time.fixedDeltaTime;
        }

        if (timer > 1f)
        {
            timer = 0f;
            Farmer_Wheat();
        }
    }

    void Farmer_Wheat()
    {
        Wheat_calculator.farmer_wheat = 1 * farmer_amount;
    }
}