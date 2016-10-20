using System;

namespace StringManipulation1
{
    class Manipulation
    {
        static void Main(string[] args)
        {
            // I write out a test data
            Console.WriteLine(StringShift("Microsoft<<2"));
        }

        static string StringShift(string input)
        {
            // variables for getting the operator indexes by trimming the input string
            // operatorr will store the found operator, before the trimming it's an empty string
            int indexOfOperator = 0;
            int operatorParameter = 0;
            string operatorr = "";

            // looking for an exact operator
            if (input.Contains("<<"))
            {
                // store the index of an integer which shows how many strings I want to trim
                indexOfOperator = input.IndexOf("<<") + 2;
                operatorr = "<<";
            }
            if (input.Contains(">>"))
            {
                indexOfOperator = input.IndexOf(">>") + 2;
                operatorr = ">>";
            }

            // store the integer which shows how many strings I want to trim
            operatorParameter = int.Parse(input.Substring(indexOfOperator, input.Length - indexOfOperator).Trim());

            // now we have both parameters to work on the string
            string purestring = input.Substring(0, indexOfOperator - 2);
            switch (operatorr)
            {
                //specify which shift does what job
                case ">>":
                    // put the trimmed string from the beginning of the pure string to the end of the pure string
                    purestring = purestring.Substring(operatorParameter, purestring.Length - operatorParameter)
                        + purestring.Substring(0, operatorParameter);
                    break;
                case "<<":
                    // put the trimmed string from the end of the pure string to the beginning of the pure string
                    purestring = purestring.Substring(purestring.Length - operatorParameter, operatorParameter)
                        + purestring.Substring(0, purestring.Length - operatorParameter);
                    break;
            }

            // give back the updated string to main()
            return purestring;
        }
    }
}
