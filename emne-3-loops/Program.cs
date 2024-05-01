// See https://aka.ms/new-console-template for more information
Console.WriteLine("LOOOPS");

//oppgave 1
void terjeForLoop()
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Terje er kul");
    }
}
terjeForLoop();

//oppgave 2
string noenOrd = "noen ord for en for each loop";

void testForEachLoop(string words)
{
    foreach (char letter in words)
    {
        Console.WriteLine(letter);
    }
}
testForEachLoop(noenOrd);

//oppgave 3
bool countTo10 = true;
int i = 1;

void roundCount()
{
    while (countTo10)
    {
        if (i < 10)
        {
            Console.WriteLine($"round number: {i}");
            i++;
        }
        else
        {
            countTo10 = false;
        }
    }
}
roundCount();
