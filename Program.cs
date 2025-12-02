using System.Runtime.Serialization;

Random rnd = new Random(DateTime.Now.Millisecond);

int direction = 0; //up
List<int> position = new List<int>(){rnd.Next(0,Console.WindowWidth),rnd.Next(0,Console.WindowHeight)};

string skin = "@";
string skinV = "║";
string skinH = "═";
string skinC = "╬";
bool CCrequest = false;
bool clearrequest = false;



int R = 0; int G = 0; int B = 0;
        R = rnd.Next(0,255);
        G = rnd.Next(0,255);
        B = rnd.Next(0,255);
int r = 0;

Console.CursorVisible = false;
Console.Clear();

while(true){
    if (CCrequest)
    {
        R = rnd.Next(0,255);
        G = rnd.Next(0,255);
        B = rnd.Next(0,255);
        CCrequest = false;
        if (clearrequest)
        {
            Console.Clear();
            r = 0;
            clearrequest = false;
        }
    }
    if(r > Console.WindowHeight*Console.WindowWidth * rnd.Next(4,7)/10)
    {
        clearrequest = true;
    }
    int pd = direction;
    List<int> op = new List<int>(position);
    if(rnd.NextDouble() > 0.65){
    direction = rnd.Next(0,4);
    if(((pd ^ direction) & 1) == 0){
        direction = pd;
    }
    }

    switch(direction){

        case 0:
            position[1] -= 1;//up
            skin = skinV;
            if(pd == 1)
            {
                skin = "╝";
            }
            if(pd == 3)
            {
                skin = "╚";
            }
        break;
        case 1:
            position[0] += 1;//right🮋⋕╳▉◯⸻︱￨𜱁𜴳𜷴|╋╬║═╔╗╚╝𜸺𜹈𜸟
            skin = skinH;
            if(pd == 0)
            {
                skin = "╔";
            }
            if(pd == 2)
            {
                skin = "╚";
            }
        break;
        case 2:
            position[1] += 1;//down
            skin = skinV;
             if(pd == 1)
            {
                skin = "╗";
            }
            if(pd == 3)
            {
                skin = "╔";
            }
        break;
        case 3:
            position[0] -= 1;//left
            skin = skinH;
            if(pd == 0)
            {
                skin = "╗";

            }
            if(pd == 2)
            {
                skin = "╝";
            }
        break;
        default:
            Console.WriteLine("ERROR");
        break;

    }

    if(position[0] > Console.WindowWidth +1){

        position[0] = 0;
        CCrequest = true;
    }
     else if(position[0] < 0){

        position[0] = Console.WindowWidth -1;
        CCrequest = true;
    }
    else  if(position[1] > Console.WindowHeight -1 ){

        position[1] = 0;
        CCrequest = true;
    }
   else if(position[1] < 0){

        position[1] = Console.WindowHeight -1;
        CCrequest = true;
    }
    if(direction != pd)
    {
       // skin = skinC;         //enable for cross skin
    }
   // Console.SetCursorPosition(op[0], op[1]);
   // Console.Write(" ");
    Console.SetCursorPosition(op[0], op[1]);
    Console.Write($"\u001b[38;2;{R};{G};{B}m{skin}");
    //Console.Write(skin);

    Thread.Sleep(50);
    r++;

}