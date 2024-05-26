using System.Xml.Resolvers;

namespace Prog120_S24_Classes
{
    internal class Program
    {
        // Class
        static int sizeOfArray = 5;
        static string[] nameOfExercises = new string[sizeOfArray];
        static int[] numberOfReps = new int[sizeOfArray];
        static double[] weights = new double[sizeOfArray];

        static Exercise[] exercises = new Exercise[5];

        static void Main(string[] args)
        {
            // Name: Vicky Le
            // Assignment: Lecture 12 - Classes
            // Date: 5/23/24

            Preload();
            PreLoadExercises();

            DisplayExerciseObjects();

            // Null Reference

            int[] numberArray = new int[3];
            // | 0 | 0 | 0 |

            Exercise[] exerciseArray = new Exercise[3];
            // | null | null | null |

            exerciseArray[0] = new Exercise();
            Console.WriteLine(exerciseArray[0].Name);


            // Creating an instance of our class, Exercise
            // DataType variableName = (new Keyword) TypeName();

            // What fields did we add to our class?
            // Name
            // Reps
            // Weight
            // Barbell Curls - 15 - 20 
            //Exercise willExercise1 = new Exercise("Barbell Curls", 15, 20); // Custom Constructor
            //Exercise willExercise2 = new Exercise(); // Calling parameterless Constructor

            ////willExercise1.Name = "Barbell Curls";
            ////willExercise1.Reps = 15;
            ////willExercise1.Weight = 20;

            ////Console.WriteLine(willExercise1.Name);
            ////Console.WriteLine(willExercise1.Reps);
            ////Console.WriteLine(willExercise1.Weight);

            //DisplayExerciseInstance(willExercise1);
            //DisplayExerciseInstance(willExercise2);



        } // Main -------------------

        // Load out Exercise array with our exercises
        public static void PreLoadExercises()
        {
            Exercise exercise0 = new Exercise("Bench Press", 10, 135);
            exercises[0] = exercise0;

            Exercise exercise1 = new Exercise("Squats", 12, 185);
            exercises[1] = exercise1;

            Exercise exercise2 = new Exercise("Deaflift", 8, 225);
            exercises[2] = exercise2;

            exercises[3] = new Exercise("Overhead Press", 10, 95);
            exercises[4] = new Exercise("Bent Over Row", 12, 115);
        }

        public static void DisplayExerciseObjects()
        {
            for (int i = 0; i < exercises.Length; i++)
            {
                Exercise currentExercise = exercises[i];
                DisplayExerciseInstance(currentExercise);
            }
        }

        // Make a method to display all exercises

        public static void DisplayExercises()
        {
            for (int i = 0; i < sizeOfArray; i++)
            {
                FormatExcercise(i);
            }
        } // Display Exercises

        public static void DisplayExerciseInstance(Exercise exercise)
        {
            // Name - Reps - Weight
            string formattedString = $"{exercise.Name} | {exercise.Reps} | {exercise.Weight}";
            Console.WriteLine(formattedString);
            //Console.WriteLine(exercise.Name);
            //Console.WriteLine(exercise.Reps);
            //Console.WriteLine(exercise.Weight);
        }

        public static void FormatExcercise(int index)
        {
            Console.WriteLine(nameOfExercises[index]);
            Console.WriteLine(numberOfReps[index]);
            Console.WriteLine(weights[index]);
            Console.WriteLine();
        }
        public static void Preload()
        {
            // Bench Press  | 10 | 135
            // Squats 12 185
            // Deadlift 8 225
            // Overhead Press 10 95
            // Sbent Over Row 12 115


            // Index 0 - Bench Press   | 10 | 135
            EnterValueIntoArray(0, "Bench Press", 10, 135);

            // Index 1 - Squats  12  185
            EnterValueIntoArray(1, "Squats", 12, 185);

            // Index 2 - Deadlift    8   225
            EnterValueIntoArray(2, "Dead Lift", 8, 225);

            // Index 3 - Overhead Press  10  95
            EnterValueIntoArray(3, "Overhead Press", 10, 95);

            // Index 4 - Bent Over Row  12  115
            EnterValueIntoArray(4, "Bent Over Row", 12, 115);


        } // Preload

        // Enter a new value to our array
        // We need to pass in index, name, rep, and weight
        public static void EnterValueIntoArray(int index, string name, int rep, double weight)
        {
            nameOfExercises[index] = name;
            numberOfReps[index] = rep;
            weights[index] = weight;
        }

    } // class
    
    // In between the closing brace for class
    // and closing brace for namespace
    // we will create a new class

    // Define a class
    // public -  keyword class - class Name ( Must be capital )
    // The name should be singular
    // Directly related to what the class is about

    public class Exercise
    {
        // Fields
        public string Name;
        public int Reps;
        public double Weight;

        // Constructor
        // Create a new Constructor
        // public ClassName (parameters) { Code }

        public Exercise(string name, int rep, double weight) // This is a default constructor
        {
            // Field = parameter
            Name = name;
            Reps = rep;
            Weight = weight;
        }
        // Create a new default constructor
        // a constructor that takes no parameters

        public Exercise()
        {
            Name = "No Exercise";
            Reps = -1;
            Weight = -1;
        }

        // Methods

    } // class Exercise

} // namespace
