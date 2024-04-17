namespace Methods;

public class Math
{
    public int Increase(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Increase(params int[] numbers) //params diyerek aslında array vereceğim diyorsun
    {
        var increased = 0;
        foreach (var number in numbers) increased = increased + number;

        return increased;

        //return numbers.Sum();
    }
}