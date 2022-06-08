namespace EventTracker.Models
{
    public class Event
    {
        // _private fields
        private int _eventId;
        
        private string _eventName = "";
        
        private string _eventLocation = "";
        
        private string _eventType = "";
        
        // constructor(s)
        
        
        // gets and sets
        public int EventId
        {
            get { return _eventId; }
            set { _eventId = value; }
        }
        public string EventName
        {
            get { return _eventName; }
            set { _eventName = value; }
        }
        public string EventLocation
        {
            get { return _eventLocation; }
            set { _eventLocation = value; }
        }
        public string EventType
        {
            get { return _eventType; }
            set { _eventType = value; }
        }
    }
}
