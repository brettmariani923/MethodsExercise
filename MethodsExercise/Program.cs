using System.Diagnostics.CodeAnalysis;

namespace MethodsExercise
{
    public class Program
    {
        static double multiply(int a, int b)
        {
            return a * b;
        }
        
        static double divide(int a, int b)
        {
            return a / b;
        }

        static int Sum(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        static int subtract(int a, int b)
        {
            return a - b;
        }
        
        static void Main(string[] args)
        
        {
            Console.WriteLine("what is your name?");
            var name = Console.ReadLine();
            
            Console.WriteLine("what is your age?");
            var age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Do you like puns?");
            var puns = Console.ReadLine();
            
            Console.WriteLine("what is your favorite color?");
            var color = Console.ReadLine();
            
            Console.WriteLine("what year were you born?");
            var yearBorn = int.Parse(Console.ReadLine());
            
            Console.WriteLine("favorite number?");
            var favNumber = int.Parse(Console.ReadLine());
            
            
            double luckyNumber = divide(yearBorn, favNumber);
           
            double moneyTime = multiply(yearBorn, favNumber);
           
            int loveYear = Sum(777, favNumber, yearBorn);
           
            int deathYear = subtract(favNumber, 2);
           

            
                Console.WriteLine($"Hello! Today's lucky number is {luckyNumber}");
                Console.WriteLine($"You will find unexpected wealth in {moneyTime} Hours");
                Console.WriteLine($"You will find love in {loveYear} hours");
                Console.WriteLine($"Expect to die in {deathYear} hours");
               
                
            
                Console.WriteLine($"hi {name}! do you like Jokes?");
                var doYouLikeJokes = Console.ReadLine();
                if (doYouLikeJokes == "yes")
                {
                    Console.WriteLine($"Its nice to hear that you like a good joke {name}. Ready? OK.\n Why do you never see hippos hiding in trees?");
                    var firstJoke = Console.ReadLine();
                
                    if (firstJoke == "because they're not very good at it")
                    {
                        Console.WriteLine("Nice job! I searched a list of puns to find one that would make you laugh. Do you want to hear it?");
                        var secondJoke = Console.ReadLine();
                        
                        if (secondJoke == "yes")
                        {
                            Console.WriteLine("Ok well sorry, I searched a top ten list of puns to find one I thought you'd like. No pun in 10 did. Sorry. So how about a story?");
                            Console.WriteLine($" {name} dropped his glasses once \n in a pot of {color} dye,\n and when {name} put them on again\n {name} saw a {color} sky.\n {color} fires were rising up\n from a {color} hill,\n Men were gringing {color} cider\n at a {color} mill\n {color} kids were playing\n with a {color} doll\n little {color} dragon flies\n were crawling up the wall\n and at the supper-table\n {name} got crazy as a loon\n from eating {color} apple dumplings\n with a {color} spoon.");
                        }
                        
                        else
                        {
                            Console.WriteLine($"well that makes sense considering you said {puns} before. How about a story instead");
                            Console.WriteLine($"{name} dropped his glasses once \n in a pot of {color} dye,\n and when {name} put them on again\n {name} saw a {color} sky.\n {color} fires were rising up\n from a {color} hill,\n Men were gringing {color} cider\n at a {color} mill\n {color} kids were playing\n with a {color} doll\n little {color} dragon flies\n were crawling up the wall\n and at the supper-table\n {name} got crazy as a loon\n from eating {color} apple dumplings\n with a {color} spoon.");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Because they're not very good at it! Want to hear another one? yes or no");
                        var secondJoke = Console.ReadLine();
                        
                        if (secondJoke == "yes")
                        {
                            Console.WriteLine($"Ok {name}! I searched a list of 10 puns to find one that would make you laugh. no pun in 10 did.\n So how about a story instead.");
                            Console.WriteLine($" {name} dropped his glasses once \n in a pot of {color} dye,\n and when {name} put them on again\n {name} saw a {color} sky.\n {color} fires were rising up\n from a {color} hill,\n Men were gringing {color} cider\n at a {color} mill\n {color} kids were playing\n with a {color} doll\n little {color} dragon flies\n were crawling up the wall\n and at the supper-table\n {name} got crazy as a loon\n from eating {color} apple dumplings\n with a {color} spoon.");
                        }
                        
                        else
                        {
                            Console.WriteLine($"Ok {name}, too old for jokes, huh, too old for humor? Is {age} too old for a laugh? What was {yearBorn} on the zodiac, the year of the stick in the mud? huh?\n Alright, how about story instead then");
                            
                            Console.WriteLine($"{name} dropped his glasses once \n in a pot of {color} dye,\n and when {name} put them on again\n {name} saw a {color} sky.\n {color} fires were rising up\n from a {color} hill,\n Men were gringing {color} cider\n at a {color} mill\n {color} kids were playing\n with a {color} doll\n little {color} dragon flies\n were crawling up the wall\n and at the supper-table\n {name} got crazy as a loon\n from eating {color} apple dumplings\n with a {color} spoon.");
                        }
                        
                        
                    }
                }

                else
                {
                    Console.WriteLine("Erm, okay. How about a story? yes or no");
                    var yesOrNo = Console.ReadLine();
                    
                    if (yesOrNo == "yes")
                    {
                        Console.WriteLine($"{name} dropped his glasses once \n in a pot of {color} dye,\n and when {name} put them on again\n {name} say a {color} sky.\n {color} fires were rising up\n from a {color} hill,\n Men were grinding {color} cider\n at a {color} mill\n {color} kids were playing\n with a {color} doll\n little {color} dragon flies\n were crawling up the wall\n and at the supper-table\n {name} got crazy as a loon\n from eating {color} apple dumplings\n with a {color} spoon.");
                    }
                    else 
                        Console.WriteLine("Erm, okay.");
                }
        }
    }
}
