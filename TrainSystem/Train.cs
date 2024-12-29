namespace TrainSystem;

public class Train
{
    private readonly Engine _engine;
    private readonly IEnumerable<Door> _doors;

    public bool IsRunning => _engine.IsRunning;

    public Train(Engine engine, IEnumerable<Door> doors)
    {
        _engine = engine;
        _doors = doors;

        foreach (var door in _doors) door.DoorStateChanged += EmergencyStop;
    }

    public void Start()
    {
        var isAnyDoorOpen = _doors.Any(door => door.IsOpen);
        if (isAnyDoorOpen) return;
        _engine.Start();
    }

    public void Stop() => _engine.Stop();

    public void EmergencyStop(object? sender, DoorStateEventArgs eventArgs)
    {
        if (!eventArgs.IsOpen) return;
        if (!IsRunning) return;

        _engine.EmergencyBreak();
        _engine.Stop();
    }
}