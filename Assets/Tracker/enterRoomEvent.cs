public class enterRoomEvent : TrackerEvent
{
    private RoomID roomID;
    public enterRoomEvent() : base(EventType.ENTER_ROOM){}
    public enterRoomEvent(RoomID roomID_) : base(EventType.ENTER_ROOM) {
        roomID = roomID_;
    }

    public void setRoomID(RoomID roomID_)
    {
        roomID = roomID_;
    }

    public RoomID getRoomID( )
    {
        return roomID;
    }
}
