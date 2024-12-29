namespace TrainSystemTest;

public partial class TrainTest
{
    private readonly Door _door1;
    private readonly Door _door2;
    private readonly Train _train;

    public TrainTest()
    {
        _door1 = new Door();
        _door2 = new Door();

        var engine = new Engine();
        var doors = new List<Door>() { _door1, _door2 };
        _train = new Train(engine, doors);
    }
}