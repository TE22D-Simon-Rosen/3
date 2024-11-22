//Steg 1
void Hello32(){
    for (int i = 0; i < 32; i++){
        Console.WriteLine("Hello, World");
    }
}


//Steg 2
void Square(int number){
    Console.WriteLine(number * number);
}


//Steg 3
float Multi(float i, float y){
    return i * y;
}


//Steg 4
float RightTriangleArea(float width, float height){
    return width * height / 2;
}


//Steg 5
double CircleArea(double radius){
    return 3.14 * radius * radius;
}


//Steg 6
int GetNumberInput(){
    string input = "";

    while (!int.TryParse(input, out int result)){
        Console.WriteLine("Write a number");
        input = Console.ReadLine();
    }

    return Convert.ToInt32(input);
}

//Steg 7
int GetChoice(string one, string two, string three){
    Console.WriteLine($"{one} \n{two} \n{three} \n\n");

    string input = "";
    while (!int.TryParse(input, out int choice)){
        Console.WriteLine("Select by typing 1, 2 or 3");

        input = Console.ReadLine();
    }

    return Convert.ToInt32(input);
}


//Steg 7
string[] stuff = {"hej", "kaos", "pppe", "sdsdg"};

int GetChoice2(string[] arrayOfThings){
    int blah = 1;
    foreach (string thing in arrayOfThings){
        Console.WriteLine($"{blah}. {thing}\n");
        blah += 1;
    }
    

    string input = "";
    while (!int.TryParse(input, out int choice)){
        Console.WriteLine("Select by typing the corresponding number");
        input = Console.ReadLine();

        if (int.TryParse(input, out int number)){
            if (number < 1 || number > arrayOfThings.Length){
                Console.WriteLine("Item does not exist, try again");
                input = "";
            }
        }
    }

    return Convert.ToInt32(input);
}