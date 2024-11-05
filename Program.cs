namespace GenericsDelegateTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "Dad",
                "Ali",
                "Moh"
            };

            FilterTransformDelegate<string, string> transofrm = x => x.Length > 3 ? x : default;
            var filtList = FilterAndTransform<string, string>(list, transofrm);

            foreach (var filt in filtList)
            {
                Console.WriteLine(filt);
            }
        }
           public static List<TOutput> FilterAndTransform<TInput, TOutput>(List<TInput> items, FilterTransformDelegate<TInput, TOutput> filterTransform)
        {
            List<TOutput> outputs = new List<TOutput>();

            foreach (var item in items)
            {
               
            var transformed = filterTransform(item);
                if (!Equals(transformed, default(TOutput)))
                {
                    outputs.Add(transformed);
                }

            }

            return outputs;
        }
        
    }
}
