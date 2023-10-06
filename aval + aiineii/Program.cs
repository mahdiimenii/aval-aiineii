Console.WriteLine("adade avale bazat ro bede");
int a1 = int.Parse(Console.ReadLine());
Console.WriteLine("adade dovom bazat ro bede");
int a2 = int.Parse(Console.ReadLine());

string str = "";
string strReversed = "";
char[] charArray;
bool avalAst = false;

for (int i = a1; i <= a2; i++)
{
    str = i.ToString();
    charArray = str.ToCharArray();
    Array.Reverse(charArray);
    strReversed = new string(charArray);
    if (str.Equals(strReversed) && i >= 11)
    {
        Console.WriteLine("adade aiineii :" + "" + i);
    }
    for (int j = 2; j < i; j++)
    {
        if (i != j && i % j == 0)
        {
            avalAst = false;
            break;
        }
        avalAst = true;
    }

    if (avalAst == true)
    {
        Console.WriteLine("adade aval :" + "" + i);
    }
}
