//start main
int userChoice = GetUserChoice();
while(userChoice!=3){//condition check
    RouteEm(userChoice);
    userChoice = GetUserChoice(); //update read

}
//end main

static int GetUserChoice() {
    DisplayMenu();
    string userChoice=Console.ReadLine();
    if(IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
    }
    else return 0;
}

static void DisplayMenu() {
    Console.Clear();
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

static bool IsValidChoice(string userInput) {
    if(userInput=="1" || userInput=="2" || userInput=="3") {
        return true;
    }
    return false;
}

static void RouteEm(int menuChoice) {
    if(menuChoice==1) {
        GetFull();
    }
    else if(menuChoice==2) {
        GetPartial();
    }
    else if(menuChoice!=3) {
        SayInvalid();
    }
    }
    
static void PauseAction() {
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
}

static void GetFull() {
   Random rand = new Random();
    int row = rand.Next(3,10);

    System.Console.WriteLine(row + "\n\n");
    for(int j = 1; j<row+1; j++) {
        for(int i = 1; i<j; i++){
            Console.Write("o");
        }
        Console.Write("o\n");

    }
PauseAction();
    
}

static void GetPartial() {
    Random rand = new Random();
    int row = rand.Next(3,10);
    System.Console.WriteLine(row + "\n\n");
    
    for(int j = 1; j<row+1; j++) {
        for(int i = 1; i<j; i++){
            int drawPiece = rand.Next(2);
            if(drawPiece==1) {       
                Console.Write("o");
            }
            else{
                Console.Write(" ");
            } 
        }
        
        Console.Write("o\n");
        
    }
    

PauseAction();
}

static void SayInvalid() {
    System.Console.WriteLine("Invalid!");
    PauseAction();
}