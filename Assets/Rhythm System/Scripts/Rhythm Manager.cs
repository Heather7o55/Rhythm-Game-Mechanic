using UnityEngine;
using System.Collections.Generic;
// https://fizzd.me/posts/how-to-make-a-rhythm-game-a-quick-and-dirty-guide-to-setting-up-your-project FNF team and other's used this basic guide.
// Worth us both looking through I think.
public class RhythmManager : MonoBehaviour
{
    public Song activeSong;
    public float songPosition;
    public float dspDelay;
    void Update()
    {
        
    }
    // Concept taken from blog listed.
    private void UpdateSongPosition()
    {
        songPosition = (float) (AudioSettings.dspTime -dspDelay) -activeSong.songAudioOffset;
    }
    // Concept taken from blog listed.
    private void OnSongStart()
    {
        dspDelay = (float) AudioSettings.dspTime;
    }
}