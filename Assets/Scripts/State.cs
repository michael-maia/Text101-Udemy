using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {
    //ScriptableObjects não precisam dos métodos: Start e Update

    [TextArea(14,10)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;

    public string GetStateStory() //função que puxa (Get) o texto da State escolhida e coloca dentro do jogo
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
