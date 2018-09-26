using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class nGenerator
    {


        private string[,,] descriptiveTraitArray;


        public nGenerator()
        {
            //default constructor
            descriptiveTraitArray[0, 0, 0] = "Lively";
            descriptiveTraitArray[0, 0, 1] = "Droopy";
            descriptiveTraitArray[0, 1, 0] = "Crazy";
            descriptiveTraitArray[0, 1, 1] = "Lethargic";
            descriptiveTraitArray[1, 0, 0] = "Spirited";
            descriptiveTraitArray[1, 0, 1] = "Merry";
            descriptiveTraitArray[1, 1, 0] = "Huffy";
            descriptiveTraitArray[1, 1, 1] = "Scary";
        }
        static void Generate()
        {
            string name;
            string descriptiveTrait1 = "";
            string descriptiveTrait2 = "";
            string descriptiveTrait3 = "";
            int x, y, z;
            bool correct = false;
            Console.WriteLine("Please enter your first name.");
            name = Console.ReadLine();
            while (correct == false)
            {
                Console.WriteLine("Which trait is more like you, tall or short?");
                descriptiveTrait1 = Console.ReadLine();
                if(descriptiveTrait1=="tall"||descriptiveTrait1=="short")
                {
                    correct = true;
                }
            }
            if(descriptiveTrait1=="tall")
            {
                x = 0;
            }
            else
            {
                x = 1;
            }
            correct = false;
            while (correct == false)
            {
                Console.WriteLine("Which trait is more like you, happy or angry? ");
                descriptiveTrait2 = Console.ReadLine();
                if (descriptiveTrait2 == "happy" || descriptiveTrait2 == "angry")
                {
                    correct = true;
                }
            }
            if (descriptiveTrait2 == "happy")
            {
                y = 0;
            }
            else
            {
                y = 1;
            }
            correct = false;
            
            while(correct == false)
            {
                Console.WriteLine("Which trait is more like you, hyper or lazy?");
                descriptiveTrait3 = Console.ReadLine();
                if (descriptiveTrait3 == "hyper" || descriptiveTrait3 == "lazy")
                {
                    correct = true;
                }
            }
            if(descriptiveTrait3 == "hyper")
            {
                z = 0;
            }
            else
            {
                z = 1;
            }

            string output = descriptiveTraitArray[x,y,z] + " " + name;
            Console.WriteLine(output);
        }
    }
}
