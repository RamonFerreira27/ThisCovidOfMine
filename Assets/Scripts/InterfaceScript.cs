using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceScript : MonoBehaviour
{
    public Slider StressSlider;
    public Slider LifeSlider;
    public Slider RestSlider;

    // Start is called before the first frame update
    void Start()
    {
        StressSlider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        StressSlider.value++;
    }
}
