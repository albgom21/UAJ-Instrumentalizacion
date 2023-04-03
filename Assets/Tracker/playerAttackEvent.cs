using UnityEngine;
public class playerAttackEvent : TrackerEvent
{

    private Vector2 posPlayer; // PREGUNTAR SI SE PUEDE USAR el tipo Vector 2 que depende de using UnityEngine;

    public playerAttackEvent() : base(EventType.POS_PLAYER_ATTACK) { }

    public playerAttackEvent(Vector2 pos) : base(EventType.POS_PLAYER_ATTACK)
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
