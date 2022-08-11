//Q2/////////////////////////////////////////////
//arry with all numbers
int[] AL_NO = new int[10] { 10, 5, 6, 7, 2, 3, 1, 12, 4, 22 };
//prime numbers arry
int[] Pr_NO = new int[10];
//varible to take the no. that is prime from all numbers to prime no. arry
int k = 0;
//to make % to no.
int[] sw = new int[1];
Console.Write("Not prime = {  ");
for (int j = 0; j < AL_NO.Length; j++)
{
    k++;
    sw[0] = AL_NO[j];
    //not prime
    if (sw[0] % 2 == 0)
        Console.Write(AL_NO[j] + "  ");
    //prime
    else
        Pr_NO[k] = AL_NO[j];
}
Console.Write("}");
Console.Write("\nprime number = {  ");
//print prime arry
for (int i = 0; i < 10; i++)
{
    if (Pr_NO[i] != 0)
        Console.Write(Pr_NO[i] + "  ");
}
Console.Write("}");
Console.WriteLine();
//Q1////////////////////////////////////////////////////////////////////
string Name;
Console.Write("Enter Your Name : ");
Name = Console.ReadLine();
remove();
void remove()
{
    Console.Write("Enter charecter to remove from name : ");
    string ch = Console.ReadLine();
    Console.WriteLine(Name.Replace(ch, string.Empty));
}
//Q3///////////////////////////////////////////////////////////////////
string Name1;
Console.Write("Enter Your Name : ");
Name1 = Console.ReadLine();
Console.Write("Enter charecter to count in name : ");
char ch = Convert.ToChar(Console.ReadLine());
Console.WriteLine(ch + " is repated " + count());
int count()
{
    int count = 0;
    List<char> chars = new List<char>();
    chars.AddRange(Name1);
    for (int i = 0; i < Name1.Length; i++)
    {
        if (chars[i] == ch)
            count++;
    }
    return count;
}