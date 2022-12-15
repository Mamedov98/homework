// See https://aka.ms/new-console-template for more information
using CosackFactoryMethod;
using CosackFactoryMethod.Classes;


int Choice =5 ;
while (Choice != 0)
{
    if (Choice != 0)
    {
        Console.WriteLine("\n1: Turkiye \n2: Russia \n3: Ukraine \n4: England");
        
        Choice = Convert.ToInt32(Console.ReadLine()); 
        CountryFactory Creator = new();
        Army Army = new Army();
        Cavalry Cavalry = new Cavalry();
        Artillery Artillery = new Artillery();   
        switch (Choice)
        { 
            case 1:
                {

                    var Country = Creator.CountryProduction<Turkey>(Army,Cavalry,Artillery);   
                    Country.Characteristics(); 
                    Country.Print(); 
                    Choice = Convert.ToInt32(Console.ReadLine());
                    break;
                } 
            case 2:
                {

                    var Country = Creator.CountryProduction<Russian>(Army,Cavalry,Artillery);   
                    Country.Characteristics(); 
                    Country.Print();             
                    Choice = Convert.ToInt32(Console.ReadLine());
                    break;
                } 
            case 3:
                {

                    var Country = Creator.CountryProduction<Ukraine>(Army,Cavalry,Artillery);   
                    Country.Characteristics(); 
                    Country.Print();   
                    Choice = Convert.ToInt32(Console.ReadLine());
                    break;
                } 
            case 4:
                {

                    var Country = Creator.CountryProduction<England>(Army,Cavalry,Artillery);   
                    Country.Characteristics();  
                    Country.Print();   
                    Choice = Convert.ToInt32(Console.ReadLine());
                    break;
                }
           

        }
    }
}