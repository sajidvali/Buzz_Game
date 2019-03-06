using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PlayMovie : MonoBehaviour
{
    public RawImage image;
    public VideoClip videoToPlay;

    private VideoPlayer videoPlayer;
    private VideoSource videoSource;
    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        Application.runInBackground = true;
        StartCoroutine(playVideo());
    }

    IEnumerator playVideo()
    {
        videoPlayer = gameObject.AddComponent<VideoPlayer>();
        audioSource = gameObject.AddComponent<AudioSource>();

        //Disable Play on Awake for both Video and Audio
        videoPlayer.playOnAwake = false;
        audioSource.playOnAwake = false;
        audioSource.Pause();
        videoPlayer.source = VideoSource.VideoClip;
        
        //Set Audio Output to AudioSource
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.EnableAudioTrack(0, true);
        videoPlayer.SetTargetAudioSource(0, audioSource);

        videoPlayer.clip = videoToPlay;
        videoPlayer.Prepare();

        while (!videoPlayer.isPrepared)
        {
            yield return null;
        }
        image.texture = videoPlayer.texture;

        //Play
        videoPlayer.Play();
        audioSource.Play();
        
        while (videoPlayer.isPlaying)
        {
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
