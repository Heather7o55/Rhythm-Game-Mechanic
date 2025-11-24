using UnityEngine;
using System.Collections.Generic;

// Declaring this struct here outside the class allows it to be used across all scripts, quite useful.
public struct Beat
    {
        int Position;
        int Lane;
    }
// This is a public class, which is how we'll construct songs, classes can be serialized to json. 
// Technically if we were being sensible this would be a scriptable object, however we want to learn to use json. 
public class Song
{
    public string songName;
    // The AudioClip already contains the songs length, no need for an extra parameter.
    public AudioClip songAudio;
    // There is normally a slight offset between the song and it actually starting beats, is worth having even if its normally 0.
    public float songAudioOffset;
    public int bpm;
    // Stole this one from the blog listed in Rhythm Manager, should be useful.
    public float beatLengthInSeconds;
    public int totalBeats;
    public List<Beat> beatMap;
}