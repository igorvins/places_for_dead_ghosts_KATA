using System.Linq;

String[] input = { "Sevap", "Syolc", "Sgulg", "Stolb", "Sknoh", "Spord", "Sgnaf", "Shcat", "Sknit", "Snirg", "Senin", "Sliob" };
char[] Earthenware = {'Q','U','T','H','C','R','D','M','Z'};
char[] Waterfall = {'W','E','V','O','X','I','N','G'};
char[] Fireplace = {'J','F','A','B','K','P','L','Y'};
char[] Windowsill = {'S'};
string[] output = new string[12];
string[] output_2 = new string[12];
int y = 0;
//For to iterate through each position
for (int i=0; i<input.Length; i++)
{
    //if verify in wich strategic position it should be set
    char first_char = input[i][0];
    string ghost_name = input[i];
    Console.WriteLine("fantasma:"+ ghost_name);
    if (i == 11 && ghost_name!= null) {
        //check all indexes of output array and insert the ghost name at the remaining blanck one
        for (int x = 0; x < input.Length; x++) {
            if (output[x]==null) { output[x] = ghost_name; }
        }
    }
    else if (Earthenware.Contains(first_char)) {
        //verify if the 1 position is empty:
        if (output[0] == null) { output[0] = ghost_name; }
        else
        {
            int v = 0;
            int j = 1;
            while (v == 0)
            {
                if (output[12 - j] == null) { output[12 - j] = ghost_name; v = 1; }
                else if (output[0 + j] == null) { output[0 + j] = ghost_name; v = 1; }
                j++;
            }
        }
    }
    else if (Waterfall.Contains(first_char)) {
        if (output[3]== null) { output[3] = ghost_name; }
        else {
            //verify the closest position from 0 index where there's no ghosts:
            int v = 0;
            int j = 1;
            while (v == 0)
            {
                //verifying if the next index exists:
                if (9 - j < 0 || 9 + j > 12)
                {
                    if (output[12 - j] == null) { output[12 - j] = ghost_name; v = 1; }
                    if (output[0 + j] == null) { output[0 + j] = ghost_name; v = 1; }
                }
                if (output[3 - j]==null){ output[3 - j] = ghost_name;v = 1; }
                else if(output[3 + j]==null){ output[3 + j] = ghost_name;v = 1; }
                j++;
            }
        }
    }
    else if (Fireplace.Contains(first_char)) {
        if (output[6] == null) { output[6] = ghost_name; }
        else
        {
            int v = 0;
            int j = 1;
            while (v == 0)
            {
                if (output[6 - j] == null) { output[6 - j] = ghost_name; v = 1; }
                else if (output[6 + j] == null) { output[6 + j] = ghost_name; v = 1; }
                j++;
            }
        }
    }
    else if (Windowsill.Contains(first_char)) {
        int v = 0;
        int j = 1;
        if (output[9] == null) { output[9] = ghost_name;}
        else {
            while (v == 0)
            {
                if (output[9 - j] == null && (9 + j) <= 12) { output[9 - j] = ghost_name; v++; }
                else if (output[9 + j] == null && (9 + j) <= 11) { output[9 + j] = ghost_name; v++; }
                //verifying if the next index exists:
                else if (9 - j < 0 || 9 + j > 11)
                {
                    if (output[12 - j] == null) { output[12 - j] = ghost_name; v++; }
                    else if (output[0 + j] == null) { output[0 + j] = ghost_name; v++; }
                }
                j++;
            }
        }
        for (int c = 0; c < output.Length; c++)
        {
            Console.WriteLine(output[c]);
        }
    }
}
//inserting _____ in blanck spaces
for (int i = 0; i < output.Length; i++)
{
    if (output[i] == null){output[i] = "_____";}
}
//printing the result
for (int i = 0; i< output.Length; i++)
{
    Console.WriteLine(output[i]);       
}
//here's the problem, if the previous one is not empty we shall look for 
//the closest one from the strategic position

//return or console.print the array, by default the empty spaces should be '_____'

