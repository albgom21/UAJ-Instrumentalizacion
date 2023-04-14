using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using P3;
using System.Collections.Generic;

public class pressButtonEvent : TrackerEvent
{
    public pressButtonEvent() : base(EventType.PRESS_BUTTON) { }

}