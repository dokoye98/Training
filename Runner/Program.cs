using Shop;

internal class Program
{
    private static void Main(string[] args)
    {
        Items i1 = new Items(1, "Shirt", 'L',23.5,true);
        Items i2= new Items(2, "Shorts", 'L',10, true);
        Items i3 = new Items(3, "Forks", 'S',1000000, false);
        Items[] itemlist =  new Items[] { i1, i2, i3 };
        Trolley t1 = new Trolley(itemlist);

        string[] names = t1.FullList();
        Purchase p1 = new Purchase();
        for(int i = 0; i < names.Length; i++)
        {
            int a = i+1;
            Console.WriteLine("This is item {0}:",a);
            Console.WriteLine(names[i]);
        }
        double totalprice = p1.TotalBill(t1);
       Console.WriteLine("Your total billis \n{0}", totalprice);
    }
}