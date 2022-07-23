using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetNumber : MonoBehaviour
{
    public TextMeshProUGUI ClockText;

    // Start is called before the first frame update
    void Start()
    {
        ClockText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
