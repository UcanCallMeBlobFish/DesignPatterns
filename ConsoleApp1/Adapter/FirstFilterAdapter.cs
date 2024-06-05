namespace ConsoleApp1.Adapter;

public class FirstFilterAdapter : FilterTarget
{
    private ThirdPartyAdaptee imported;

    public FirstFilterAdapter(ThirdPartyAdaptee thirdPartyAdaptee)
    {
        imported = thirdPartyAdaptee;
    }


    public void applyFilter(Image image)
    {
        imported.init();
        imported.apply();
    }
}