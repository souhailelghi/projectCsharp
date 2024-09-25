////BancAcount cih = new BancAcount();
////cih.NameBanc = "marooc cih";
////cih.Refereces = "DH";
////cih.balence = 1000;

////cih.TakeMony(200);
////cih.TransferMony(100);



////class BancAcount
////{
////    //properters : 
////    public  string NameBanc { get; set; }
////    public  string Refereces { get; set; }
////    public int balence { get; set; }


////    // method and function : 

////    public void TransferMony(int mony)
////    {
////        int NewBalence = balence - mony;

////        if(balence < 0)
////        {
////            Console.WriteLine("invalide operation !!");
////        }
////        else
////        {
////            Console.WriteLine($"your mony befre trans is :  {balence} ");
////            Console.WriteLine($"after transfer you have new : {NewBalence}");
////        }
////        //Console.WriteLine($"Date :{DateOnly()} ");
////        Console.WriteLine("date 00-00-0000");
////    }


////    public void TakeMony(int mony)
////    {
////        int newbalence = balence + mony;
////        Console.WriteLine($"you have new {newbalence} ");
////        Console.WriteLine("date of take mony is  : 00-00-0000");
////    }
////}


//Console.WriteLine("example constructore copy :");
//Enemy zombi = new Enemy("zombiz",100);


//Enemy dib = new Enemy(zombi);

//Console.WriteLine(zombi.Name);
//Console.WriteLine(zombi.Health);
//Console.WriteLine(dib.Name);
//Console.WriteLine(dib.Health);

//class Enemy
//{
//    //property : 
//    public int  Id { get; set; }
//    public string Name { get; set; }
//    public int Health { get; set; }

//    //constructur with Params : 
//    public Enemy ( string n, int h)
//    {

//        Console.WriteLine("constructur with Params");
//        Name = n;
//        Health = h; 


//    }

//    //constructur Copy : 
//    public Enemy(Enemy enemy)
//    {
//        Console.WriteLine("constructur Copy");
//        Name = enemy.Name;
//        Health = enemy.Health;
//    }
//}


//Console.WriteLine("example private constructure :");


//Counter.Number = 10;
//Counter.Incrument();
//Console.WriteLine($"the new number is : {Counter.Incrument()}");



//class Counter
//{
//    //variabel : 
//    public static int Number;

//    public static int Count;



//    //private constructure 
//    private Counter() {

//    }

//    //method for incrument 
//    public static int Incrument()
//    { return ++Number; }
//}

//Console.WriteLine("example for instance construtore ");
////----------------------- example for instance construtore ------------------------------


//Enemy Vijita = new Enemy();
//Enemy zombe = new Enemy();
//Enemy Freeza = new Enemy();
//class Enemy
//{
//    private static int instanceNum = 0;
//    private static int StaticNum = 0;

//    public int Id { get; set; }
//    public string Health { get; set; }
//    public string Name { get; set; }

//    public Enemy()
//    {
//        instanceNum++;
//        Console.WriteLine($"the instnce is  : {instanceNum}");
//    }
//    static Enemy()
//    {
//        StaticNum++;
//        Console.WriteLine($"the static is  : {StaticNum}");
//    }
//}



Bank cih = new Bank();
Bank.acountStatic();
cih.acountWitoutStatic();
class Bank
{
    public static void acountStatic()
    {
        Console.WriteLine("return static ");
    }
    public  void acountWitoutStatic()
    {
        Console.WriteLine("return Non static ");
    }
}