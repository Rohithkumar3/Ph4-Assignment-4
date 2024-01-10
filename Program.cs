// See https://aka.ms/new-console-template for more information


using Assignment4;

List<Product> products = new List<Product>()
{
    new Product() {Id=1,PName="Mobile",PBrand="Samsung",MfgDate=new DateTime(day:12,month:11,year:2022),ExpDate=new DateTime(day:12,month:12,year:2023)},
    new Product() {Id=2,PName="Laptop",PBrand="HP\t",MfgDate=new DateTime(day:11,month:01,year:2023),ExpDate=new DateTime(day:12,month:12,year:2025)},
    new Product() {Id=3,PName="Earpods",PBrand="Boat\t",MfgDate=new DateTime(day:10,month:06,year:2021),ExpDate=new DateTime(day:12,month:12,year:2024)},
    new Product() {Id=4,PName="Tab",PBrand="Redmi\t",MfgDate=new DateTime(day:25,month:12,year:2020),ExpDate=new DateTime(day:12,month:12,year:2023)},
    new Product() {Id=5,PName="Trimmer",PBrand="Phillips",MfgDate=new DateTime(day:28,month:10,year:2020),ExpDate=new DateTime(day:12,month:12,year:2022)}
};

Console.WriteLine("ID\t PName \t PBrand \t MfgDate \t\t ExpDate");
foreach (Product pro in products)
{
    Console.Write(pro.Id + "\t");
    Console.Write(pro.PName + "\t ");
    Console.Write(pro.PBrand + "\t ");
    Console.Write(pro.MfgDate.ToLongDateString()+"\t");
    Console.Write(pro.ExpDate.ToLongDateString());
    Console.WriteLine("\n");
}