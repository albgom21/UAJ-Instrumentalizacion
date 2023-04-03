﻿public class exitRoomEvent : TrackerEvent
{
    private RoomID roomID;
    public exitRoomEvent() : base(EventType.EXIT_ROOM){}
    public exitRoomEvent(RoomID roomID_) : base(EventType.EXIT_ROOM) {
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