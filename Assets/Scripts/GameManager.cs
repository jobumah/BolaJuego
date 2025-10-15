using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text TextoPunto;
    private int Puntos;
    private int totalCubos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        Puntos = 0;
        TextoPunto.text = Puntos.ToString();
        totalCubos = transform.childCount;

    }

    void Update()
    {
        if (Puntos >= totalCubos)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        

    }
    public void SumarPuntos()
    {
        Puntos++;
        TextoPunto.text = Puntos.ToString();

    }


}
