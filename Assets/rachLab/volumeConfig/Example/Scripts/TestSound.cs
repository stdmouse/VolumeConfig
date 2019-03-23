using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestSound : MonoBehaviour
{
    public AudioClip clip;
    AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            source.PlayOneShot(clip);
        }

        if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadSceneAsync("Test");
        }
    }
}
