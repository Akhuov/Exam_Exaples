
//Berilgan mijozlar va buyurtmalar ro'yxatlarini bog'langan joylashuvga asoslanib, mijozlar buyurtmalari bilan birga mijozlarning ismlarini olish uchun LINQ so'rov yozing.

using Exam_Exaples;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

var customers = new List<Customer>()
{
    new Customer() { Id = 1,Name= "AAA"},
    new Customer() { Id = 2,Name= "BBB"},
    new Customer() { Id = 3,Name= "CCC"},
    new Customer() { Id = 4,Name= "DDD"},
    new Customer() { Id = 5,Name= "FFF"}
};

var orders = new List<Order>()
{
    new Order(){ Id = 1,Name ="ACC",ExModelId = 1,Price = 1123},
    new Order(){ Id = 2,Name ="ABC",ExModelId = 2,Price = 2132},
    new Order(){ Id = 3,Name ="AXX",ExModelId = 1,Price = 12000}
};
//Berilgan mijozlar va buyurtmalar ro'yxatlari orqali mijozlarning buyurtmalari haqidagi ma'lumotlarni olish uchun "SelectMany" operatorini ishlatib, mijozlar va buyurtmalar bilan bog'langan yangi ro'yxat yaratib oling.

var customerOrders = customers
            .SelectMany(customer => orders.Where(order => order.Id == customer.Id), (customer, order) => new { Customer = customer, Order = order })
            .ToList();

foreach (var customer in customerOrders)
{
    Console.WriteLine($"{customer.Customer.Id} {customer.Customer.Name} Orders: {customer.Order.Id} {customer.Order.Name} {customer.Order.ExModelId}");
}


//var customerList = customers
//            .OrderBy(c => orders.Count(o => o.ExModelId == c.Id))
//            .ToList();

//foreach (var customer in customerList)
//{
//    Console.WriteLine(customer.Name);
//}
//var result  = orders.OrderByDescending(x=>x.Price);

//foreach (var order in orders)
//{
//    Console.WriteLine(order.Name+" "+ order.Price);
//}


//var customerInfo = customers
//                .Join(orders, c => c.Id, o => o.ExModelId, (c, o) => new { Customer = c, Order = o })
//                .GroupBy(co => co.Customer, co => co.Order, (key, group) => new
//                {
//                    Customer = key,
//                    Orders = group.ToList()
//                });

//foreach (var customer in customerInfo)
//{
//    Console.WriteLine(customer.Customer.Name);
//    foreach (var order in customer.Orders)
//    {
//        Console.WriteLine(order.Name);
//    }
//    Console.WriteLine();
//}




//Berilgan raqamlar ro'yxatidan juft raqamlarni olgan holda yangi ro'yxat yarating, shu bilan birga raqamlar sonini ham hisoblang.


//var list_1 =  new List<int>() {1,2,3,4,512,142,5212,52,312,132412};
//var juftlar = list_1.Select(x => x%2==0).Count();
//Console.WriteLine(juftlar);

//Berilgan mijozlar ro'yxatidan mijozlar ismi va familiyasini olgan holda yangi ro'yxat yarating.



//var list_1 = new List<int>() { 1, 2, 3, 4, 51, 142, 5212, 52, 312, 132412 };
//var juftlar = list_1.OrderBy(x=>x);
//foreach(var item in juftlar)
//{
//    Console.WriteLine(item);
//}

//using Exam_Exaples;

//var persons = new List<Person>()
//{
//    new Person(){Id = 1,FirstName = "Qaxxor",LastName ="Pattoxov"},
//    new Person(){Id = 2,FirstName = "Farrux",LastName ="Xamraev"},
//    new Person(){Id = 3,FirstName = "Amir",LastName ="Pulatov"},
//};

//var newList = persons.OrderBy(c=>c.LastName);

//foreach (var person in newList)
//{
//    Console.WriteLine(person.LastName);

//}

//var list_1 = new List<int>() { -1, 2, 3, 4, 51, 142, 5212, 52, 312, 132412 };
//bool musbatmi = list_1.All(x => x > 0);

//Console.WriteLine(musbatmi);'



//var list = new List<object> { 10, "Hello", 20, "World", 30 };

//var numberList = list.OfType<int>().ToList();
//var stringList = list.OfType<string>().ToList();

//foreach (var number in numberList)
//{
//    Console.WriteLine(number);
//}
//Console.WriteLine();

//foreach (var str in stringList)
//{
//    Console.WriteLine(str);
////}
//string text = "oracle is an orasdw sadt orae aas orcolor";
//string[] words = text.Split(' ');
//var result = words.Where(w => w.StartsWith("or", StringComparison.OrdinalIgnoreCase)).ToList();

//string text = "sfad fas sfSF asf  frSgdst and  aga snadsdfck";
//string[] words = text.Split(' ');
//var result = words.Where(w => w.Contains("a")).ToList();

//string text = "asdasf ipssdgsum asdfew se adw, asdawe asfa gewga";
//string[] words = text.Split(' ');

//var list_1 = words.Where(w => w.Length > 5).OrderBy(w => w).ToList();
//var list_2 = words.Where(w => w.Length <= 5).OrderByDescending(w => w).ToList();

//var combinedList = list_1.Concat(list_2).ToList();

//string text = "Men Shunchaki! Kulub  Quydim Dista Lova Lova uu?";
//string[] words = text.Split(' ');

//var result = words
//    .Select(w => new { Word = w, Count = w.Count(c => c == 'o') })
//    .OrderByDescending(item => item.Count)
//    .Select(item => $"{item.Word}: {item.Count}")
//    .ToList();

//List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
//List<int> list2 = new List<int> { 3, 4, 5, 6, 7 };

//var commonElements = list1.Intersect(list2).OrderBy(element => element).ToList();

//List<int> list1 = new List<int> { 1, 3, 5 };
//List<int> list2 = new List<int> { 2, 4, 6 };

//List<int> mergedList = list1.Concat(list2).OrderBy(element => element).ToList();


//using Dapper;
//using Exam_Exaples;
//using System.Data.SqlClient;

//var ConnectionString = @"Server=WIN-F7NIMF7A3VO;
//                                    Database=BootCamp_N7;
//                                    Trusted_Connection=True;
//                                    Pooling = True;";

//using (SqlConnection connect = new SqlConnection(ConnectionString))
//{
//    try
//    {
//        connect.Open();
//        Console.WriteLine(ConnectionString);
//        Console.WriteLine("\n\n");

//        string query = "Select * from Fruits";

//        SqlCommand cmd = new SqlCommand(query, connect);

//        using (SqlDataReader reader = cmd.ExecuteReader())
//        {
//            int c = 0;

//            while (reader.Read())
//            {
//                c = reader.FieldCount;
//                for (int i = 0; i < c; i++)
//                {
//                    Console.Write(reader[i] + "\t");
//                }

//                Console.WriteLine();

//            }

//            Console.WriteLine("\n\n" + c);
//        }
//    }
//    catch (Exception exeption)
//    {
//        Console.WriteLine(exeption.Message);
//    }
//}

//using (SqlConnection connect = new SqlConnection(ConnectionString))
//{
//    var query = "Select * From IdIsm";

//    IEnumerable<IdIsm> result = connect.Query<IdIsm>(query);
//}


//List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
//List<int> list2 = new List<int> { 3, 4, 5, 6, 7 };

//List<int> commonElements = list1.Except(list2).OrderBy(element => element).ToList();

//foreach (int element in commonElements)
//{
//    Console.WriteLine(element);
//}



//Kiritilgan ro'yxatdagi elementlar orasidan yangi bir ro'yxat yaratib, faqat bosh harfi "A" bilan boshlanadigan so'zlarini chiqaring.
//var list = new List<string>() { "Mdasfas", "asfsafaw", "Masfas" };
//var result = list.OrderBy(x=>x).Where(x => x.StartsWith("M"));
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


//List<int> list1 = new List<int> { 1, 3,2, 5 };
//List<int> list2 = new List<int> { 2, 4, 6 };
//List<int> mergedList = list1.Except(list2).OrderBy(element => element).ToList();

//foreach (var item in mergedList)
//{
//    Console.WriteLine(item);
//}

//List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
//List<int> list2 = new List<int> { 3, 4, 5, 6, 7 };

//List<int> uniqueElements = list1.Except(list2).Concat(list2.Except(list1)).ToList();

//foreach (int element in uniqueElements)
//{
//    Console.WriteLine(element);
//}

