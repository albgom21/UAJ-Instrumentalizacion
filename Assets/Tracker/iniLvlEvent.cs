public class iniLvlEvent : TrackerEvent
{
    private int lvlID;
    public iniLvlEvent() : base(EventType.INI_LVL){}
    public iniLvlEvent(int lvlID_) : base(EventType.INI_LVL) {
        lvlID = lvlID_;
    }

    public void setLvlID (int lvlID_)
    {
        lvlID = lvlID_;
    }

    public int getLvlID( )
    {
        return lvlID;
    }
}
