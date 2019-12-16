using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionGame : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject sphere = null;
    GameObject game_manager = null;
    void Start()
    {
        sphere = GameObject.FindGameObjectWithTag("Sphere");
        game_manager = GameObject.FindGameObjectWithTag("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetInstanceID() == sphere.GetInstanceID()) 
        {
            game_manager.GetComponent<GameManager>().termine = true;

        }
    }
}
