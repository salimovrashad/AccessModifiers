using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();

            Console.WriteLine("Noutbuk sayini daxil edin...");
            notebook.Count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < notebook.Count; i++)
            {
                Console.WriteLine("Noutbuk qiymetini daxil edin...");
                notebook.Price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Noutbuk brandini daxil edin...");
                notebook.Brand = Console.ReadLine();
                Console.WriteLine("Noutbuk modelini daxil edin...");
                notebook.Model = Console.ReadLine();
                Console.WriteLine("Noutbuk ram olcusunu daxil edin...");
                notebook.Ram = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Noutbuk yaddas olcusunu daxil edin...");
                notebook.Storage = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Noutbuk adi: {notebook.Brand},noutbukun modeli: {notebook.Model}, ram olcusu: {notebook.Ram}, yaddas olcusu: {notebook.Storage}. Qiymeti: {notebook.Price}");
            }

        }
    }
}