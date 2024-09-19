using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

[RequireComponent(typeof(VideoPlayer))]
public class VideoManager : MonoBehaviour
{

    public Button PlayButton;

    VideoPlayer myVideoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        myVideoPlayer = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (myVideoPlayer.isPlaying)
        {
            ShowPlayButton(false);
        }
        else
            ShowPlayButton(true);
    }

    void PauseVideo(bool pause)
    {
        if (pause)
            Pause();
    }

    public void Play()
    {
        myVideoPlayer.Play();
        ShowPlayButton(false);
    }

    public void Pause()
    {
        if (myVideoPlayer)
        {
            myVideoPlayer.Pause();
            ShowPlayButton(true);
        }
    }
    
    
    void ShowPlayButton(bool check)
    {
        PlayButton.enabled = check;
        PlayButton.GetComponent<Image>().enabled = check;
    }
}
