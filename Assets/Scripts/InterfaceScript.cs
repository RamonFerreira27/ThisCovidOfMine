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
    public Text TempoTexto;
    public Image clockHand;
    private const float SEGUNDOS_REAIS_POR_DIA = 30f;
    private float dia;
    public int contaDia = 01;

    public float rotacao;
    public float normalizacaoDia;
    public float grausRotacaoPorDia = 360f;

    private void Awake()
    {
        StressSlider.value = 0;
        TempoTexto.text = "Dia " + contaDia;
    }

    private void FixedUpdate()
    {
        StressSlider.value++;

        //Realizando a rotação da Agulha do relogio
        dia += Time.deltaTime / SEGUNDOS_REAIS_POR_DIA;

        normalizacaoDia = dia % 1f;
        //tempo = -Time.realtimeSinceStartup * 30f;
        clockHand.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -normalizacaoDia * grausRotacaoPorDia));
        rotacao = clockHand.transform.rotation.eulerAngles.z;

        if (normalizacaoDia > 0.9988f) {
            contaDia++;
            TempoTexto.text = "Dia " + contaDia;
        }
    }
}
