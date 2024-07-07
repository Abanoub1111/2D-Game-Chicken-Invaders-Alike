using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLives : MonoBehaviour
{
    public int Lives = 3;
    public Image[] LivesUI;
    public GameObject explosionPrefab;
    //public GameObject explosionPrefab;
    // Start is called before the first frame update
    AudioManager audioManager;
    // Start is called before the first frame update

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("audio").GetComponent<AudioManager>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag == "Enemy")
        {
            audioManager.Playbeat(audioManager.collision);
            Destroy(collision.collider.gameObject);
            Instantiate(explosionPrefab, transform.position, quaternion.identity);
            //Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Lives -= 1;
            for(int i = 0; i < LivesUI.Length; i++)
            {
                if(i < Lives)
                {
                    LivesUI[i].enabled = true;
                }
                else
                {
                    LivesUI[i].enabled = false;
                }
            }
            if(Lives <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("gameover");
            }

        }
        if(collision.collider.gameObject.tag == "Boss")
        {
            audioManager.Playbeat(audioManager.collision);
            //Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Lives -= 1;
            for(int i = 0; i < LivesUI.Length; i++)
            {
                if(i < Lives)
                {
                    LivesUI[i].enabled = true;
                }
                else
                {
                    LivesUI[i].enabled = false;
                }
            }
            if(Lives <= 0)
            {
                Destroy(gameObject); //teara
                SceneManager.LoadScene("gameover");
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "egg")
        {
            audioManager.Playbeat(audioManager.collision);
            Destroy(collision.gameObject);
            Instantiate(explosionPrefab, transform.position, quaternion.identity);
            //Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Lives -= 1;
            for(int i = 0; i < LivesUI.Length; i++)
            {
                if(i < Lives)
                {
                    LivesUI[i].enabled = true;
                }
                else
                {
                    LivesUI[i].enabled = false;
                }
            }
            if(Lives <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("gameover");
            }

        }
    }
}
