using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent; //[SerializeField] cria uma referência dentro do Unity para poder alterar o seu valor
    [SerializeField] State startingState; //O parametro startingState tem que ser o StartingState.asset para começar a história a partir do início

    State state;

    // Use this for initialization
    void Start () {
        state = startingState;
        textComponent.text = state.GetStateStory();
	}
	
	// Update is called once per frame
	void Update () {
        ManageState();
	}

    private void ManageState() //esta função vai servir para que o jogador escolha uma das opções dadas durante as histórias
    {
        var nextStates = state.GetNextStates();
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }
        textComponent.text = state.GetStateStory(); //serve para atualizar o o texto de acordo com a State que escolhemos
    }
}
