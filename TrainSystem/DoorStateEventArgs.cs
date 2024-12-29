namespace TrainSystem;

public class DoorStateEventArgs(bool isOpen) : EventArgs
{
    public bool IsOpen { get; } = isOpen;
}