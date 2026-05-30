using UnityEngine;
using TMPro;

public class pointos : MonoBehaviour
{

    public TMP_Text scoreText;

    const string ScoreKey = "CurrentScore";
    int puntuacion = 0;

    void Start()
    {    
        PlayerPrefs.SetInt(ScoreKey, 0);
        ActualizarTexto();
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("pointo"))
        {
            puntuacion = PlayerPrefs.GetInt(ScoreKey, 0) + 1;
            PlayerPrefs.SetInt(ScoreKey, puntuacion);
            ActualizarTexto();
        }
    }


   
    void ActualizarTexto()
    {
        if (scoreText != null)
            scoreText.text = puntuacion.ToString();
    }
}
