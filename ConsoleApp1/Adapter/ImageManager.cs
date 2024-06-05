namespace ConsoleApp1.Adapter;

public class ImageManager
{
    private Image img;

    public ImageManager(Image imgg)
    {
        img = imgg;
        
    }
    public void filter(FilterTarget filter)
    {
        filter.applyFilter(img);
    }
}