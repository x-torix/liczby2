// See https://aka.ms/new-console-template for more information

Random gra = new Random();
bool playAgain = true;
int min = 1;
int max = 10;
int guess; /*?*/
int number;
int guesses;

while (playAgain)
{
    guess = 0;
    guesses = 0;    
    number = gra.Next(min, max + 1);

    while (guess != number)
    {
        Console.WriteLine("Wybrałem liczbę od 1 do 10. Zgadnij jaka to liczba: ");
        guess = Convert.ToInt32(Console.ReadLine());

        if (guess > number)
        {
            Console.WriteLine(guess + " jest za wysoka!");
        }
        else if (guess < number)
        {
            Console.WriteLine(guess + " jest za niska!");
        }
        guesses++;
    }
    Console.WriteLine("Numer: " + number);
    Console.WriteLine("WYGRAŁ*Ś!");
    Console.WriteLine("Odpowiedzi: " + guesses);
    break;
}
