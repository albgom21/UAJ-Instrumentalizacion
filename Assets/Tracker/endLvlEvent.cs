using P3;
public class endLvlEvent : TrackerEvent
{
    private int lvlID;
    public endLvlEvent() : base(EventType.END_LVL) { }
    public endLvlEvent(int lvlid) : base(EventType.END_LVL)
    {
        lvlID = lvlid;
    }

    public void setLvlID(int lvlid)
    {
        lvlID = lvlid;
    }

    public int getLvlID()
    {
        return lvlID;
    }
}