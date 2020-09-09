using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameOverText;
    public bool gameOver;// valor por defecto false acuerdate inche pablitomix
    public static GameControler Instance;
    public float scrollSpeed = -1.5f;
    public Text scoreText;

    private int score;

    private void Awake()
    {
        if (GameControler.Instance == null)
        {
            GameControler.Instance = this;
        }
        else if (GameControler.Instance != this)
        {
            Destroy(gameObject);
            Debug.LogWarning("El abjeto a sido instanciado por segunda vez y no deberia de pasar");
        }
    }

    public void BirdScore()
    {
        if (gameOver) return;

        score++;
        scoreText.text = "Score" + score;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);//carga la esena en la que esta actualmente
        }
    }

    public void BirdDie() 
    {
        gameOverText.SetActive(true);//Activa un componete
        gameOver = true;
    }

    private void OnDestroy()
    {
        if (GameControler.Instance == this) 
        {
            GameControler.Instance = null;
        }
    }
}
