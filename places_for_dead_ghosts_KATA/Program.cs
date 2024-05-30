using System.Linq;

String[] input = { "Artlu", "Breca", "Cityl", "Dedaf" };
char[] Earthenware = {'Q','U','T','H','C','R','D','M','Z'};
char[] Waterfall = {'W','E','V','O','X','I','N','G'};
char[] Fireplace = {'J','F','A','B','K','P','L','Y'};
char[] Windowsill = {'S'};
string[] output = new string[12];

//For to iterate through each position
for (int i=0; i<input.Length; i++)
{
    //if verify in wich strategic position it should be set
    char first_char = input[i][0];
    string ghost_name = input[i];
    if (Earthenware.Contains(first_char)) {
        //verify if the 1 position is empty:
        if (output[0] == null) { output[0] = ghost_name; }
        else if (output[11] == null) { output[11] = ghost_name; }
        else { }
    }
    else if (Waterfall.Contains(first_char)) {
        if (output[3]== null) { output[3] = ghost_name; }
        else {
            //verify the closest position from 0 index where there's no ghosts:
            int v = 0;
            while (v == 0)
            {
                int j = 1;
                if(output[3 - j]==null){ output[3 - j] = ghost_name;v = 1; }
                else if(output[3 + j]==null){ output[3 + j] = ghost_name;v = 1; }
                j++;
            }
        }
    }
    else if (Fireplace.Contains(first_char)) {
        if (output[6]==null) { output[6] = ghost_name; }
        else if (output[5]== null) { output[5] = ghost_name; }
        else { }
    }
    else if (Windowsill.Contains(first_char)) {
        if (output[9]== null) { output[9] = ghost_name; }
        else if (output[8]== null) { output[8] = ghost_name; }
        else { }
    }
    else { }
}
//inserting _____ in blanck spaces
for (int i = 0; i < output.Length; i++)
{
    if (output[i] == null){output[i] = "_____";}
}
for (int i = 0; i< output.Length; i++)
{
    Console.WriteLine(output[i]);       
}

//here's the problem, if the previous one is not empty we shall look for 
//the closest one from the strategic position

//return or console.print the array, by default the empty spaces should be '_____'

