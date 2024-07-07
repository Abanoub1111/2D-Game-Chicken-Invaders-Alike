using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
{
    public float moveSpeed;
    private pointManager pointManager;
    public GameObject explosionPrefab;
    //public float Fire;
    // Start is called before the first frame update
    AudioManager audioManager;
    // Start is called before the first frame update

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("audio").GetComponent<AudioManager>();
    }
    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<pointManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            audioManager.Playbeat(audioManager.death);
            pointManager.UpdateScore(1);
            if(pointManager.score == 12){
                SceneManager.LoadScene("level 2");
            }

        }

        if(collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Boss"))
        {
            Destroy(gameObject);
            pointManager.UpdateScore(1);
            audioManager.Playbeat(audioManager.death);
            if(pointManager.score == 12){
                Destroy(collision.gameObject);
                SceneManager.LoadScene("youwon");
            }
            
        }

    }
}
