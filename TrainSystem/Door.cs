namespace TrainSystem;

public class Door
{
    public bool IsOpen { get; private set; }

    public event EventHandler<DoorStateEventArgs>? DoorStateChanged;

    public void Open()
    {
        IsOpen = true;
        var eventArgs = new DoorStateEventArgs(true);
        DoorStateChanged?.Invoke(this, eventArgs);
    }

    public void Close()
    {
        IsOpen = false;
        var eventArgs = new DoorStateEventArgs(false);
        DoorStateChanged?.Invoke(this, eventArgs);
    }
}