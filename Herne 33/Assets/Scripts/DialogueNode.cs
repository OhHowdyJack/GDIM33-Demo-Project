using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerReply
{
    public string line;
    public DialogueNode nextNode;
}


[CreateAssetMenu(fileName = "DialogueLine", menuName = "ScriptableObjects/DialogueLine", order = 1)]
public class DialogueNode : ScriptableObject
{
    [Tooltip("The lines of dialogue the NPC says in this node.")]
    public List<string> Lines;

    [Tooltip("The dialogue options for the player's response, and what node each response leads to.")]
    public List<PlayerReply> ReplyOptions;
}
