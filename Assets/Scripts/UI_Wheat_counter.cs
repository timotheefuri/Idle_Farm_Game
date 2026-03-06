using UnityEngine;
using TMPro;

public class UI_elementa : MonoBehaviour
{

    public TMP_Text text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Wheat: " + Wheat_calculator.wheat_counter +
            "WPS: " + Wheat_calculator.wheat_counter_seconds;
    }
}
