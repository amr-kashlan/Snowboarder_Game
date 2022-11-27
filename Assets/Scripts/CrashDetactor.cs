using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetactor : MonoBehaviour
{
    public ParticleSystem groundSystem;
    public bool didDie = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && didDie)
        {
            didDie = false;
            FindObjectOfType<PlayerController>().DisableControlls();


            groundSystem.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", 1f);

        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);

    }
}

