using UnityEngine;
using P3;

public class playerInteractEvent : TrackerEvent
{
    private Vector2 posPlayer;

    public playerInteractEvent() : base(EventType.POS_PLAYER_INTERACT) { }

    public playerInteractEvent(Vector2 pos) : base(EventType.POS_PLAYER_INTERACT)
    {
        posPlayer = pos;
    }

    public void setPos(Vector2 pos)
    {
        posPlayer = pos;
    }

    public Vector2 getPos()
    {
        return posPlayer;
    }
}