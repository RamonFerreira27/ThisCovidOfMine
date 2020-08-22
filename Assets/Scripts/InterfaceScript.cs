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
    private const int SEGUNDOS_REAIS_POR_DIA = 180;
    private float dia;
    public int contaDia = 01;

    public float rotacao;
    public float normalizacaoDia;
    public float grausRotacaoPorDia = 360;
    public float tempo;

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

        normalizacaoDia = dia % 1;
        tempo = normalizacaoDia *grausRotacaoPorDia;
        clockHand.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -tempo));
        rotacao = clockHand.transform.rotation.eulerAngles.z;

        if (tempo > 359.98)
        {   
            clockHand.transform.rotation = Quaternion.Euler(0, 0, 0);
            contaDia++;
            TempoTexto.text = "Dia " + contaDia;
        }
    }
}
