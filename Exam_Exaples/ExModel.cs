namespace Exam_Exaples
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int ExModelId { get; set; }
    }
}
