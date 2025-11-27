using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;
// https://fizzd.me/posts/how-to-make-a-rhythm-game-a-quick-and-dirty-guide-to-setting-up-your-project FNF team and other's used this basic guide.
// Worth us both looking through I think.
public class RhythmManager : MonoBehaviour
{
    public Song activeSong;
    public bool songActive = false;
    public float songPosition;
    public float dspDelay;
    void Update()
    {
        if(!songActive) return;
        UpdateSongPosition();
    }
    // Concept taken from blog listed.
    private void UpdateSongPosition()
    {
        songPosition = (float) (AudioSettings.dspTime -dspDelay) -activeSong.songAudioOffset;
    }
    // Concept taken from blog listed.
    public void StartSong()
    {
        songActive = true;
        dspDelay = (float) AudioSettings.dspTime;
    }

    public bool OnBeat(float lastBeat)
    {
        return songPosition > lastBeat + activeSong.beatLengthInSeconds;
    }
}