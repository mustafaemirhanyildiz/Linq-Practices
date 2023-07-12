using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("----------Linq Practices || Easy Sorular---------------");
        Console.WriteLine();
        //Given an array of integers, write a query that returns list of numbers greater than 30 and less than 100.
        List<int> list = new List<int> { 67, 92, 153, 15 };

        var numbers = list.Where(l => l > 30).Where(l => l < 100);
        Console.WriteLine("Soru 1 bir list içinde 30 ile 100 arasındaki sayıları bul array input -> 67, 92, 153, 15");
        foreach (var num in numbers)
        {   
            Console.WriteLine(num);
            Console.WriteLine();

        }


        // Write a query that returns words at least 5 characters long and make them uppercase.
        List<string> words = new List<string> { "orange", "apple", "pineapple", "banana" ,"kiwi","fig"};
        var wordList = words.Where(w => w.Length > 5).Select(w=>w.ToUpper());
        Console.WriteLine("Soru 2 bir list içinde 6 karakterden uzun olanları büyük harfe çevir array input -> orange, apple, pineapple, banana");
        foreach (var item in wordList)
        {
            Console.WriteLine(item);
            Console.WriteLine();

        }

        // write a query that returns the top 3 most expensive products.
        List<Product> products = new List<Product>
        {
            new Product { Name = "Keyboard", Price = 20 },
            new Product { Name = "Mouse", Price = 10 },
            new Product { Name = "Monitor", Price = 100 },
            new Product { Name = "Printer", Price = 50 },
            new Product { Name = "Scanner", Price = 80 },
            new Product { Name = "Computer", Price = 500 }
        };

        var top3Products = products.OrderByDescending(p => p.Price).Take(3);
        Console.WriteLine("Soru 3 bir product list'i içinde fiyatı en yüksek olan 3 product'ı getir. ");
        foreach (var item in top3Products)
        {
            Console.WriteLine(item.Name);
            Console.WriteLine();
        }



        // Write a query that returns words starting with letter 'b' and ending with letter 'a'.
        List<string> cities=new List<string> { "Ankara", "Istanbul", "Adana", "Bursa", "Antalya", "Mersin", "Izmir" ,"balıkesir"};
        var cityList=cities.Where(c=>(c.StartsWith("B") || c.StartsWith("b")) && c.EndsWith("a"));
        Console.WriteLine("Soru 4 bir list içinde B ile başlayan ve a ile biten şehirleri getir. ");
        foreach (var item in cityList)
        {
            Console.WriteLine(item);
            Console.WriteLine();

        }

        // Write a query that returns list of numbers and their squares only if square is greater than 20
        List<int> numbersSquare=new List<int> { 3, 9, 2, 8, 6, 5 };
        var numsSquare = numbersSquare.Where(x => x * x > 20);
        Console.WriteLine("Soru 5 bir list içinde sayıların karesini al ve 20'den büyük olanları getir. ");
        foreach(var item in numsSquare)
        {
            Console.WriteLine(item);
            Console.WriteLine();

        }

        // Write a query that replaces 'ea' substring with astersik (*) in given list of words.
        List<string> strings = new List<string> { "bread", "meat", "cheese", "apple", "pear" };
        var strList= strings.Select(s => s.Replace("ea", "*"));
        Console.WriteLine("Soru 6 bir list içinde ea olan kelimeleri * ile değiştir. ");
        foreach (var item in strList)
        {
            Console.WriteLine(item);
            Console.WriteLine();

        }


        Console.WriteLine("----------------- Easy Sorular bitti --------------------");
        Console.WriteLine();

        Console.WriteLine("----------Linq Practices || Medium Sorular---------------");


        // Write a query that shuffles sorted array.
        List<int> sortedList = new List<int> { 1, 2, 3, 4, 5, 6 ,7,8,9,10};
        var shuffleList = sortedList.OrderBy(x =>GetRandomNumber(0,sortedList.Count-1));
        Console.WriteLine("Soru 1 bir list içindeki sayıları karıştır. ");
        foreach (var item in shuffleList)
        {
            Console.WriteLine(item);
            Console.WriteLine();

        }


        static int GetRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        // Given a non-empty string consisting only of special chars (!, @, # etc.), return a number (as a string) where each digit corresponds to given special char on the keyboard ( 1→ !, 2 → @, 3 → # etc.).

        char[] charArr=new char[] {')','!','@','#','$','%','^','&','*','('};

        var stringEncrypted="!@#$%^&*()";
        var stringDecrypted=stringEncrypted.Select(s=>charArr.ToList().IndexOf(s));
         Console.WriteLine("Soru 2 bir string içindeki karakterleri şifrele. ");
        foreach (var item in stringDecrypted)
        {
            Console.WriteLine(item);
            Console.WriteLine();

        }

        // Write a query that returns most frequent character in string. Assume that there is only one such character.
        string str = "abbddjwwwkkacksckcsck";
        var mostFrequentChar=str.GroupBy(s=>s).OrderByDescending(s=>s.Count()).Take(1);
        Console.WriteLine("Soru 3 bir string içindeki en çok tekrar eden karakteri bul. ");
        foreach (var item in mostFrequentChar)
        {
            Console.WriteLine(item.Key);
            Console.WriteLine();

        }

        // Given a non-empty list of strings, return a list that contains only unique (non-duplicate) strings.
        List<string> stringList = new List<string> { "abc", "xyz", "klm", "xyz", "abc", "abc", "rst" };
        var uniqueList=stringList.GroupBy(s=>s).Where(x=>x.Count()==1);
        Console.WriteLine("Soru 4 bir string list içindeki tekrar etmeyen elemanları bul. ");
        foreach (var item in uniqueList)
        {
            Console.WriteLine(item.Key);
            Console.WriteLine();

        }


        // Write a query that returns only uppercase words from string.
        string upperCaseString= "DDD example CQRS Event Sourcing";
        var upperCase=upperCaseString.Split(" ").Where(s=>s.ToUpper()==s.ToString());
        Console.WriteLine("Soru 5 bir string içindeki büyük harfle yazılan kelimeleri bul. ");
        foreach (var item in upperCase)
        {
            Console.WriteLine(item);
            Console.WriteLine();

        }

        // Write a query that returns dot product of two arrays.
        List<int> productArray1 = new List<int> { 1, 2, 3 };
        List<int> productArray2 = new List<int> { 4, 5, 6 };
        var productArray = productArray1
                    .Zip(productArray2, (x, y) => x * y)
                 ;
        Console.WriteLine("Soru 6 iki array içindeki elemanların çarpımını bul. ");

        Console.WriteLine(productArray.Sum());

        // Write a query that returns letters and their frequencies in the string.
        string str2 = "abbddjwwwkkacksckcsck"; 
        var letterFrequency=str2.GroupBy(s=>s).Select(s=>new {key = s.Key, frequency=s.Count()});
        Console.WriteLine("Soru 7 bir string içindeki harflerin frekansını bul. ");
        foreach (var item in letterFrequency)
        {
            Console.WriteLine(item);
            Console.WriteLine();

        }

        

        // write a query that returns day names from enum.

        var dayNames = Enum.GetValues(typeof(DayOfWeek))
         .Cast<DayOfWeek>()
         .Select(day => day.ToString());

        Console.WriteLine("Soru 8 enum içindeki günleri bul. ");
        foreach (var dayName in dayNames)
        {
            Console.WriteLine(dayName);
        }



    }
}

internal class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
}