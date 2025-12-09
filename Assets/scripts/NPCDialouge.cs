using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering.Universal;

[CreateAssetMenu(fileName ="NewNPCDialouge", menuName = "NPC Dialouge")]
public class NPCDialouge : ScriptableObject
{
    public string npcName;
    public Sprite npcPortrait;
    public string[] dialougeLines;
    public float typingSpeed = 0.05f;
    public bool[] autoProgressLines;
    public float autoProgressDelay = 1.5f; 
}
