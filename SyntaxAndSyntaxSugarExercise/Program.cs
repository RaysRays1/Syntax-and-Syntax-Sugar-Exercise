namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)

        {
            // Given the following code, change the code to implement:

            int answer = 4;
            string response;
            if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + " greater than or equal to nine";
            }

           // Console.WriteLine(response);
            
            // String Interpolation:
            // Ternary Operation:
            // Conditions ?, Truescope, Falsescope


            
            response = (answer < 9) ? "Is less than nine!" : "Greater than or equal to nine";
            Console.WriteLine(response);




        }
        
        
        
    }
}
