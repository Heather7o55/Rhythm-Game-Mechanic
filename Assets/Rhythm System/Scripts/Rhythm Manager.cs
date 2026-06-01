using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;
// https://fizzd.me/posts/how-to-make-a-rhythm-game-a-quick-and-dirty-guide-to-setting-up-your-project FNF team and other's used this basic guide.
// Worth us both looking through I think.
public class RhythmManager : MonoBehaviour
{
    public Song activeSong;
    public float songPosition;
    public int currentBeat;
    public float dspDelay;
    public AudioSource speaker;
    void Update()
    {

    }
    // Concept taken from blog listed.
    public void UpdateSongPosition()
    {
        currentBeat = (int) (songPosition / activeSong.beatLengthInSeconds);
        songPosition = (float) (AudioSettings.dspTime -dspDelay) -activeSong.songAudioOffset;
    }
    // Concept taken from blog listed.
    public void StartSong()
    {
        speaker.clip = activeSong.songAudio;
        speaker.Play();
        dspDelay = (float) AudioSettings.dspTime;
    }

    public bool OnBeat(float lastBeat)
    {
        return songPosition > lastBeat + activeSong.beatLengthInSeconds;
    }

//ALL OF THIS IS BAD CODE, PLEASE REWRITE IT IN THE MORNING JESUS CHRIST
    public bool RhythmKeyPressed()
    {
        if(Input.GetKeyDown("w")) return true;
        if(Input.GetKeyDown("a")) return true;
        if(Input.GetKeyDown("s")) return true;
        if(Input.GetKeyDown("d")) return true;
        return false;
    }
    public int GetRhythmKey()
    {
        if(Input.GetKeyDown("w")) return 1;
        if(Input.GetKeyDown("a")) return 2;
        if(Input.GetKeyDown("s")) return 3;
        if(Input.GetKeyDown("d")) return 4;
        return 0;
    }
}