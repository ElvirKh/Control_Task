Console.WriteLine("Введите массив символов через запятую");
string  [] inputArray = Console.ReadLine().Split(",");

string [] answerArray = new string[inputArray.Length];
int indexAnswerArray = 0;

for (int i =0; i<inputArray.Length; i++)
{
    if (inputArray[i].Length<=3)
    {
        answerArray[indexAnswerArray] = inputArray[i];
        indexAnswerArray++;
    }
}

for (int i=0; i<indexAnswerArray;i++)
{
    if (i<indexAnswerArray-1 ) Console.Write(answerArray[i]+",");
    else Console.Write(answerArray[i]);
    
}