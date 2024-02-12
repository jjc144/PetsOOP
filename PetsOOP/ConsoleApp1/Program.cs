


using ClassLibrary1;

string input = "";

while (input != "4")
{ 
Console.WriteLine("Welcome to the Pet Store");
Console.WriteLine("1. Add a new Pet");
Console.WriteLine("2. List all pets");
Console.WriteLine("3. Have 2 pets meet");
Console.WriteLine("4. Exit");
    input = Console.ReadLine();
    switch (input)
    {
        case "1":
            Console.WriteLine("1. Add a new cat");
            string petname = Console.ReadLine();
            Console.WriteLine("2. Add a new Chimpanzee");
            Console.WriteLine("3. add a new Turtle");
            string input2 = Console.ReadLine();
            switch (input2)
            {
                case "1":
                    Cat newCat = new Cat(petname);
                    break;
                case "2":
                    Chimpanzee newChimp = new Chimpanzee(petname);
                    break;
                case "3":
                    Turtle newTurtle = new Turtle(petname);
                    break;

            }
            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
            break;
        default:
            break;

        
                 
    }

}
