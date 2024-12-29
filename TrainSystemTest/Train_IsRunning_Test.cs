namespace TrainSystemTest;

public partial class TrainTest
{
    [Fact]
    public void IsRunning_ReturnTrue_GivenCloseDoor()
    {
        _train.Start();
        _train.IsRunning.Should().BeTrue();
    }

    [Fact]
    public void IsRunning_ReturnFalse_GivenOpenDoor()
    {
        _door2.Open();
        _train.Start();
        _train.IsRunning.Should().BeFalse();
    }

    [Fact]
    public void IsRunning_ReturnFalse_GivenOpenDoorAfterStart()
    {
        _train.Start();
        _train.IsRunning.Should().BeTrue();

        _door2.Open();
        _train.IsRunning.Should().BeFalse();
    }
}