using System;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

namespace GDIM33Demo
{
    [CreateAssetMenu(fileName = "DialogueLine", menuName = "ScriptableObjects/DialogueLine", order = 1)]
    public class DialogueNode : ScriptableObject
    {
        [Tooltip("The lines of dialogue the NPC says in this node.")]
        public List<string> Lines;

        [Tooltip("The dialogue options for the player's response, and what node each response leads to.")]
        public List<PlayerReply> ReplyOptions;
    }
}