using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject sphere = null;
    GameObject text = null;
    public float time_to_end = 3.0f;
    public float time_actual = 0.0f;
    public bool termine = false;
    public bool primera_vez = true;
    Vector3 position;
    void Start()
    {
        sphere = GameObject.FindGameObjectWithTag("Sphere");
        text = GameObject.FindGameObjectWithTag("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        if (sphere.transform.position.y < -2 || termine) 
        {

            if(primera_vez)
            {
                position = sphere.transform.position;
                primera_vez = false;

            }

            sphere.transform.position = position;
            text.SetActive(true);
            time_actual += Time.deltaTime;

            if (time_actual > time_to_end)
            {
                GameOver();
                time_actual = 0;
            }
        }
        else
        {
            text.SetActive(false);
        }
        
    }

    public void GameOver()
    {
       
       string currentSceneName = SceneManager.GetActiveScene().name;
       SceneManager.LoadScene(currentSceneName);
       
    }
        
}
