using UnityEngine;

public class RhythmManager : MonoBehaviour
{
    private Song song;
    private float songLength;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        songLength = song.totalBeats / song.bmp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
