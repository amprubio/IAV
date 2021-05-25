﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public GameObject NoneNode;
    public GameObject TeamANode;
    public GameObject TeamBNode;
    enum State{None, TeamA, TeamB};
    private State mState_;
    private void Start() {
     mState_=State.None; 
     NoneNode.SetActive(true);
     
     TeamANode.SetActive(true); 
    }
    public void SetTeamA(){
        mState_= State.TeamA;
        
     NoneNode.SetActive(false);
     TeamANode.SetActive(true);
    }

    public void SetTeamB(){
        mState_= State.TeamB;
     NoneNode.SetActive(false);
     TeamANode.SetActive(true);
    }
}
