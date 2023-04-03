public class FilePersistance  : IPersistance
{
    public FilePersistance() { }
  
    public override void Send(TrackerEvent te)
    {
        throw new System.NotImplementedException();
    }

    public override void Flush()
    {
        throw new System.NotImplementedException();
    }
}