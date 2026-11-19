public class Device
{
    private string? _model;
    protected string? Model;

    public Device(string model) => _model = model;

    public void ShowModel() => Console.WriteLine(_model);
}