using UnityEngine;
using TMPro;

public class Pointosmuestra : MonoBehaviour
{
    public TMP_Text scoreText;
    const string ScoreKey = "CurrentScore";
    void Start()
    {
        int puntuacion = PlayerPrefs.GetInt(ScoreKey, 0);
        if (scoreText != null)
            scoreText.text = "Score: " + puntuacion.ToString();
    }
}
