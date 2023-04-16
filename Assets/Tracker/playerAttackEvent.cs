using P3;
public class playerAttackEvent : TrackerEvent
{
    public float posX, posY;

    public playerAttackEvent(float posX_, float posY_) : base(EventType.POS_PLAYER_ATTACK)
    {
        posX = posX_;
        posY = posY_;
    }
}
