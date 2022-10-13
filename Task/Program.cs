// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. 


string[] str = new string[] {"Rus", "Den", "Kaz"};

int ii = 0;

 for(int i = 0; i<str.Length; i++)
{
    if (str[i].Length<=3)
    {
        ii++;
    }
}

string[] strnew = new string[ii];

ii = 0;

 for(int i = 0; i<str.Length; i++)
{
    if (str[i].Length<=3)
    {
        strnew[ii] = str[i];
        ii++;
    }
}

 for(int i = 0; i<strnew.Length; i++)
{
    System.Console.WriteLine(strnew[i]);      
}
