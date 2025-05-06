namespace neetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerEncodeAndDecodeStrings();
        }

        public static void ManagerEncodeAndDecodeStrings()
        {
            List<string> InputOne = new List<string>([""]);
            List<string> InputTwo = new List<string>(["we", "say", ":", "yes"]);

            EncodeAndDecodeStrings encodeAndDecodeStrings = new EncodeAndDecodeStrings();

            var _one = encodeAndDecodeStrings.Encode(InputOne);
            foreach(string str in encodeAndDecodeStrings.Decode(_one))
            {
                Console.Write(str + " - "); 
            }
            Console.WriteLine("");

            var _two = encodeAndDecodeStrings.Encode(InputTwo);
            Console.WriteLine(_two);
            foreach (string str in encodeAndDecodeStrings.Decode(_two))
            {
                Console.Write(str + " - ");
            }
            Console.WriteLine("");
        }

    }
}
