namespace try_catch;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayı: "+ sayi);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: "+ ex.Message.ToString());
        }
        finally
        {
            Console.WriteLine("İşlem tamamlandı..!");
        }

        try
        {
            //int s=int.Parse(null);
            //int a = int.Parse("test");
            int s1=int.Parse("2222222222222222");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Boş değer girdiniz");
            Console.WriteLine(ex);
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Veri tipi uygun değil");
            Console.WriteLine(ex);
        }
        catch(OverflowException ex)
        {
            Console.WriteLine("Veri sınır dışında");
            Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine("İşlem tamam");
        }
    }
}
