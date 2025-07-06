using UnityEngine;

public class AudioTest : MonoBehaviour {

    // AudioClip audioClip;
    public AudioClip music;
    public AudioClip se;

    // AudioSource 
    private AudioSource player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        player = GetComponent<AudioSource>();

        // Play the music clip
        player.clip = music;

        //loop the music
        player.loop = true;

        player.volume = 0.5f; // Set volume to 50%

        player.Play();

        Debug.Log("AudioTest Start");
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Space key pressed");
            if (player.isPlaying) {
                player.Pause();
               // player.Stop();
            } else {
                player.UnPause();
                //player.Play();
            }
        }

        if (Input.GetMouseButtonDown(0)) {
                       Debug.Log("Mouse button pressed");
            // Play the sound effect clip
            player.PlayOneShot(se, 0.5f); // Play sound effect at 50% volume
        }
    }
}
