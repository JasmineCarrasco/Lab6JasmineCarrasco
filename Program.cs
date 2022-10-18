// In Program.cs write a function named StackNoParams The function makes 5 Value Type Variables.
void StackNoParms()
{
    

    int a = 1;
    int b = 2;
    int c = 3;
    int d = 4;
    int e = 5;
    menu();
}


//Write a function name StackWithParams the Function makes 3 Value type parameters

long StackWithParams(long f)
{
long g = 6;
long h = 7;
long i = 8;
long l = f + g + h + i;
menu();
return l;
}



 // Write a function named StackWithHeap
// The function takes 3 Value type of parameters , the function takes1 reference type parameter the function makes 2 Value type variables the function makes 1 reference type variable

string StackWithHeap(string j){
int k = 1;
int m = k - 1;
int n = 7;
string reference = j;
double o = 5;
bool p = true;
string q =  "Here now gone later.";
Console.WriteLine(j + q);
menu();
return j;

}


//Write a function called StackOver 
//the function creates a stack overflow error.
//"I showed how this is done in class"



long x =0;
void StackOver()
{
    StackOver();
    {
        StackOver();
    {
    StackOver();
    menu();
    
    }
    }
    }



//Write a Driver program to call each Function / menu
void menu(){
Console.WriteLine("Choose what function you want. 1 , 2 , 3 or  4.");
string Choice = Console.ReadLine();
switch (Choice){ 

    case "1" : StackNoParms();
    break;
    case "2" : StackWithParams(18);
    break;
    case "3" : StackWithHeap("Here now gone later.");
    break;
    case "4" : StackOver();
    break;



}

}
menu();