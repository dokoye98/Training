using Shop;

internal class Program
{
    private static void Main(string[] args)
    {
        Items i1 = new Items(1, "Shirt", 'L',true);
        Items i2= new Items(2, "Shorts", 'L', true);
        Items i3 = new Items(3, "Forks", 'S', false);
        Items[] itemlist =  new Items[] { i1, i2, i3 };
        Trolley t1 = new Trolley(itemlist);

        string[] names = t1.FullList();

        for(int i = 0; i < names.Length; i++)
        {
            int a = i+1;
            Console.WriteLine("This is item {0}:",a);
            Console.WriteLine(names[i]);
        }
    }
}