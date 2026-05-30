using UnityEngine;
using TMPro;

public class pointos : MonoBehaviour
{

    public TMP_Text scoreText;

    int puntuacion = 0;

    void Start()
    {    
        ActualizarTexto();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other == null)
            return;

        if (other.CompareTag("pointo"))
        {
            SumarPunto();
        }
    }


    void SumarPunto()
    {
        puntuacion++;
        ActualizarTexto();
    }

    void ActualizarTexto()
    {
        if (scoreText != null)
            scoreText.text = puntuacion.ToString();
    }
}
