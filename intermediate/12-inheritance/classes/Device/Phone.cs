namespace Inheritance;

class Phone : Device
{
    public Phone(string model)
        : base(model) => Model = model;

    public void ShowPhoneModel() => Console.WriteLine(Model);
}
