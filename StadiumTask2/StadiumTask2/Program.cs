using System;
using StadiumTask2;

namespace StadiumTask2.Models

{
    class Program
    {
        static void Main(string[] args)
        {

            StadiumData stadiumData = new StadiumData();

            bool check = true;
            string answer;
            string stadiumName = "";
            string hourPriceStr;
            decimal hourPrice;
            string capacityStr;
            byte capacity;
            string selectedIdStr;
            int selectedId;


            do
            {
                Console.WriteLine("1. Stadion elave et");
                Console.WriteLine("2. Stadionlari goster");
                Console.WriteLine("3. Verilmis id-li stadionu goster");
                Console.WriteLine("4. Verilmis id-li stadionu sil");
                Console.WriteLine("5. Istifadeci elave et");
                Console.WriteLine("6. Istifadecileri goster");
                Console.WriteLine("7. Rezervasiyalari goster");
                Console.WriteLine("8. Rezervasiya yarat");
                Console.WriteLine("9. Verilmis id-li stadionun rezervasiyalarini goster");
                Console.WriteLine("0. Sistemden cix");

                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        do
                        {
                            Console.WriteLine("Stadion adini daxil edin: ");
                            stadiumName = Console.ReadLine();
                        } while (stadiumName.Length < 256 && String.IsNullOrEmpty(stadiumName));

                        do
                        {
                            Console.WriteLine("Stadionun saatliq qiymetini daxil edin: ");
                            hourPriceStr = Console.ReadLine();
                        } while (!decimal.TryParse(hourPriceStr, out hourPrice));

                        do
                        {
                            Console.WriteLine("Stadionun tutumunu yazin: ");
                            capacityStr = Console.ReadLine();
                        } while (!byte.TryParse(capacityStr, out capacity));

                        Stadium stadium = new Stadium
                        {
                            Name = stadiumName,
                            HourlyPrice = hourPrice,
                            Capacity = capacity,
                        };

                        stadiumData.AddStadium(stadium);
                        break;
                    case "2":
                        foreach (var item in stadiumData.GetAll())
                        {
                            Console.WriteLine($"{item.Id} - {item.Name} - {item.HourlyPrice} - {item.Capacity}");
                        };
                        break;
                    case "3":
                        do
                        {
                            Console.WriteLine("Id daxil edin: ");
                            selectedIdStr = Console.ReadLine();
                        } while (!int.TryParse(selectedIdStr, out selectedId) && stadiumData.GetAll().Count < selectedId);

                        Console.WriteLine(stadiumData.GetById(selectedId).Name);
                        break;
                    case "4":
                        do
                        {
                            Console.WriteLine("Id daxil edin: ");
                            selectedIdStr = Console.ReadLine();
                        } while (!int.TryParse(selectedIdStr, out selectedId) && stadiumData.GetAll().Count < selectedId);

                        stadiumData.DeleteById(selectedId);
                        break;
                    case "0":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Duzgun deyer daxil edin: ");
                        break;
                }


            } while (check);
        }
    }
}
