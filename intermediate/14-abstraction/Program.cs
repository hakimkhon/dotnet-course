using Abstraction.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        // Task 1
        MediaAsset[] mediaAssets = { new AudioAsset(), new VideoAsset(), new PodcastAsset() };

        foreach (MediaAsset mediaAsset in mediaAssets)
        {
            mediaAsset.GetFormat();
            mediaAsset.Play();
        }

    // Task 2
    Appliance[] appliances =
        {
            new WashingMachine("Kir yuvish mashinasi"), 
            new AirHeater("Isitgich"),
            new ElectricKettle("Choynak"),
        };

        appliances[0].CalculatePowerConsumption(1);
        appliances[1].CalculatePowerConsumption(2);
        appliances[2].CalculatePowerConsumption(3);

    }
}
