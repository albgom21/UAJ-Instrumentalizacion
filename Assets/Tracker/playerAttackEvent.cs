using UnityEngine;
using P3;
public class playerAttackEvent : TrackerEvent
{
    public float posX, posY;

    //public playerAttackEvent() : base(EventType.POS_PLAYER_ATTACK) { }

    public playerAttackEvent(float posX_, float posY_) : base(EventType.POS_PLAYER_ATTACK)
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
