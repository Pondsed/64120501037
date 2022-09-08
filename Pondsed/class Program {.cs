using System;

public class Shop{
    public string name;
    private double num;
    public string Own;
    private double val;
    public Shop(string name,double num,string Own,double val){
    this.name = name;
    this.num = num;
    this.Own = Own;
    this.val = val;
    }
    public static void ShopInformation(Shop Shop){
        Console.WriteLine("----------Shop Information------------");
        Console.WriteLine("Name : {0}",Shop.name);
        Console.WriteLine("Number : {0}",Shop.num);
        Console.WriteLine("Owner Name : {0}",Shop.Own);
        Console.WriteLine("Registered Value : {0}",Shop.val);
        Console.WriteLine("--------------------------------------");
    }
    public static void MoneyCalcu(Shop Shop){
        Console.WriteLine("Please input money:");
      double money = double.Parse(Console.ReadLine());
      double m,i,ii,iii,iv,v,vi,vii,viii,ix,x,xi;
      i = money/1000;
      m = money%1000;
      ii = m/500;
      m = m%500;
      iii = m/100;
      m = m%100;
      iv = m/50;
      m = m%50;
      v = m/20;
      m = m%20;
      vi = m/10;
      m = m%10;
      vii = m/5;
      m = m%5;
      viii = m/2;
      m = m%2;
      ix = m/1;
      m = m%1;
      x = m/.50;
      m = m%.50;
      xi = m/.25;
      m = m%.25;
      Console.WriteLine("1000: {0}", Math.Floor(i));
      Console.WriteLine("500: {0}", Math.Floor(ii));
      Console.WriteLine("100: {0}", Math.Floor(iii));
      Console.WriteLine("50: {0}", Math.Floor(iv));
      Console.WriteLine("20: {0}", Math.Floor(v));
      Console.WriteLine("10: {0}", Math.Floor(vi));
      Console.WriteLine("5: {0}", Math.Floor(vii));
      Console.WriteLine("2: {0}", Math.Floor(viii));
      Console.WriteLine("1: {0}", Math.Floor(ix));
      Console.WriteLine(".50: {0}", Math.Floor(x));
      Console.WriteLine(".25: {0}", Math.Floor(xi));
      double[] output={Math.Floor(i),Math.Floor(ii),Math.Floor(iii),Math.Floor(iv),Math.Floor(v),Math.Floor(vi),Math.Floor(vii),Math.Floor(viii),Math.Floor(ix),Math.Floor(x),Math.Floor(xi)};
    }
}
public class Program{
    public static void Main(string[] args){
        
        Console.WriteLine("Please Input Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Please Input Number : ");
        double num = double.Parse(Console.ReadLine());
        Console.WriteLine("Please Input Owner name : ");
        string Own = Console.ReadLine();
        Console.WriteLine("Please Input Registered Value : ");
        double val = double.Parse(Console.ReadLine());
    Shop shop = new Shop(name,num,Own,val);
    Shop.ShopInformation(shop);
    Shop.MoneyCalcu(shop);
    }
    }
