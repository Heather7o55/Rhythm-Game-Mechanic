using UnityEngine;
using System.Collections.Generic;
/*  This is a public class, which is how we'll construct songs, classes can be serialized to json. 
    Technically if we were being sensible this would be a scriptable object, however we want to learn to use json. */
public class Song
{
    public int bpm;
    public int totalBeats;
    public float songLength;
    public struct Beat
    {
        int Position;
        int Lane;
    }
    public List<Beat> beatMap;
}