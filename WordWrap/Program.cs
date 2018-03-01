using System;

namespace WordWrap
{
    class Program
    {
        static void Main(string[] args)
        {
            var wrapper = new WordWrapper();

            var text = "Lorem ipsum dolor sit amet, eum te soleat oporteat accusamus. Ex mutat conceptam pro, vel exerci debitis probatus ad. Delectus lobortis perpetua ius an, et ius porro inermis consetetur, sit et dicant delicata signiferumque. Has atqui posidonium an, te sed odio torquatos, vidisse civibus propriae pri ei.";

            Console.WriteLine(wrapper.Wrap(text, 13));

            Console.ReadLine();
        }
    }
}
