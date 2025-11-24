using UnityEngine;
using System.Collections.Generic;
using UnityEditor;
// Beginnings of a custom song editor within unity, useless for now, but have begun outlining.
// Unity's docs in this area are a little vague, so might take a bit before its working.
// Following this tutorial https://youtu.be/34736DHWzaI but will need a lot of adapting and further research.
public class SongEditorWindow : EditorWindow
{
    Song song = new Song();
    public string songName = "New Song";
    public AudioClip songAudio;
    public int bpm;
    public int totalBeats;
    public List<Beat> beatMap;

    [MenuItem("Tools/Song Editor")]
    public static void ShowWindow()
    {
        GetWindow(typeof(SongEditorWindow));
    }
    private void OnGUI()
    {
        GUILayout.Label("Create New Song", EditorStyles.boldLabel);
        songName = EditorGUILayout.TextField("Song Name", songName);
    }
}