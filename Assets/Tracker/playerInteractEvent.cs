using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using P3;
using System.Collections.Generic;
using UnityEngine;

public class playerInteractEvent : TrackerEvent
{
    public float posX, posY;

    //public playerInteractEvent() : base(EventType.POS_PLAYER_INTERACT) { }

    public playerInteractEvent(float posX_, float posY_) : base(EventType.POS_PLAYER_INTERACT)
    {
        posX = posX_;
        posY = posY_;
    }

    //public void setPos(Vector2 pos)
    //{
    //    posPlayer = pos;
    //}

    //public Vector2 getPos()
    //{
    //    return posPlayer;
    //}
}