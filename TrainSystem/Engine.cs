namespace TrainSystem;

public class Engine
{
    public bool IsRunning { get; private set; }

    public void Start() => IsRunning = true;

    public void Stop() => IsRunning = false;

    public void EmergencyBreak() { }
}
