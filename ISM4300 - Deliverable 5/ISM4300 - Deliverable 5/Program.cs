/*Author: Pedro Nader
 * Deliverable 5 ISM
 * The purpose of this is to practice methods and random objects
 * Also good to practice arrays
 */

namespace ISM4300___Deliverable_5;
class Program
{
    //Creating method to generate random Array
    static int[] createArray(int range) //Integer parameter for size of the array
    {
        int[] newArray = new int[range]; //Define the size equals to the parameter to be inputted
        Random rnd = new Random(); //Creating random object from Random Class
        for (int i = 0; i < newArray.Length; i++) //Iterate through all the indexes to apply random number
        {
            newArray[i] = rnd.Next(0,100); //Random number between 0 and 100
        }
        return newArray; //Return the Array
    }
    static int SumArray(int[] array) //Paramenter is an array for the sumArray method/function created
    {
        int sum = 0; //Sum at first is 0
        foreach (int elem in array)
        {
            sum = sum + elem; //For each element in the array add it to the sum
        }
        return sum; //return sum
    }

    static void print(string message) //Just to make it easier instead of writing Console.WriteLine all the time.
    {
        Console.WriteLine(message);
    }

    static void Main(string[] args)
    {

        print("Please enter a number between 5 and 15 to be your array length");
        int input = 0; //Have to define a value for it to not raise error before running. 0 is the best

        Boolean done = false;
        while (!done) //Loop until it is successful
        {
            try //try to get the input if not raise error
            {
                input = int.Parse(Console.ReadLine());
                if (input >= 5 && input <= 15){  //only mark it as done if inside the range
                    done = true;
                }
                else
                {
                    print("Enter a number on a valid range"); //error message will lead the loop to run again because 'done' still false
                }
            }
            catch
            {
                print("Enter a valid number"); //If the input is not a number
            }
        }

        //create my array and string sequence with all the numbers in it so we can print it on the same line
        int[] myArray = createArray(input);

        //the loop is just to print everything
        Console.Write("The array of " + input + " numbers is: ");
        foreach (int no in myArray)
        {
            Console.Write(no + " ");
        }
        //Skip line
        print(" ");


        //using the function to calculate the sum
        int sum = SumArray(myArray);

        //printing the sum
        print("The sum is: " + sum.ToString());
        Console.ReadKey(true);
    }
}

