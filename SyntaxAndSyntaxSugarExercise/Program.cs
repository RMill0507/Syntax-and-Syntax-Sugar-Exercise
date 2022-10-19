namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            
            var response = (answer > 9) ? $"{answer} is smaller than 9" : $"{answer} is bigger than 9";
            
            Console.WriteLine(response);    
            
            

        }
    }
}
