﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IDG;
using IDG.FightClient;
public class Cube : NetObject {
    // public NetInfo net;
    static int cubuid=1;
    

    protected new void Start()
    {
        base.Start();
        name = "cube" + cubuid++;
        //ShapPhysics.tree.Add(net);
        net.Position = new V2(transform.position.x, transform.position.z);
        if(net.Shap==null) net.Shap = new BoxShap(new Ratio(1),new Ratio(1));
        net.name = name;
        

        
    }
    //float last;
    protected override void FrameUpdate()
    {
       
        V2 move = net.Input.GetJoyStickDirection(FrameKey.MoveKey);
     
        net.Position += move * net.deltaTime;
        if (move.x != 0 || move.y != 0)
        {
            net.Rotation = move.ToRotation();
        }
        //Debug.Log(net.Position);
    }

    // Use this for initialization
   
	
	// Update is called once per frame
	//void Update () {
		
	//}

}
