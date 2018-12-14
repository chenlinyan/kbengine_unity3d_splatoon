﻿using CBFrame.Sys;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INKFISH_IDLE : SMState
{

    private Avatar _avatar;
    private CharacterMotion _characterMotionObj;
    public INKFISH_IDLE(string name, GameObject go) :
        base(name, go)
    {
        _avatar = gameObject.GetComponent<Avatar>();
        _characterMotionObj = gameObject.transform.GetComponent<CharacterMotion>();
    }

    public override void OnUpdate()
    {
        _characterMotionObj.Idle();
    }
}
