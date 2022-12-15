using PatternBridge;
using PatternBridge.Classes;



int switch_on = 3;

Console.WriteLine("Выберите способ Доставки \n 1 : На Мотоцикле \n 2 : На Такси ");
switch_on = Convert.ToInt32(Console.ReadLine());
switch (switch_on)
{
    case 1:
        {
            var Customer = new Customer();
            Delivery delivery = new Delivery();
            delivery = new ChangeDelivery(new DeliveryByMotorcycle());
            Customer.CustomerChoice(delivery);


            break;
        }
    case 2:
        {
            var Customer = new Customer();
            Delivery delivery = new Delivery();
            delivery = new(new TaxiDelivery());
            Customer.CustomerChoice(delivery);

            break;
        }
}



