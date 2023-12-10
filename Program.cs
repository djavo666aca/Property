namespace Property
{
    class Storage {
        public string NekiString
        { get; set; }

        public int NekiInt
        { get; set;}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage s = new Storage();
            
            s.NekiString = "Neki string";
            s.NekiInt = 1;

            Console.WriteLine(s.NekiString);
            Console.WriteLine(s.NekiInt);
        }
    }
}
