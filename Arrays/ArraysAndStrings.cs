namespace Arrays
{
    internal class ArraysAndStrings
    {
        //Punto3
        public int CountCharInString(string inputString, char inputChar)
        {
            int result = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputChar == inputString[i])
                {
                    result += 1;
                }
            }
            //TODO: Escriba aquí el algoritmo para contar
            // las ocurrencias de inputChar en inputString

            return result;
        }
// Punto 1
        public int NextPowerOfTwo(int currentNumber)
        {
            int result = 1;
            while (currentNumber >= result)
            {
                result = result * 2;
            }
            return result;
        }
//Punto 2 //En la serie Fibonacci hay un error por lo tanto puede que el codigo no de bien en el test
        public int FibonacciAtN(int fibonacciPosition)
        {
            int result = 0;
            int Index1 = 0;
            int Index2 = 0;
            int Number = 0;
            
            for (int i = 0; i < fibonacciPosition; i++)
            {
                if (i == 0)
                {
                    Number = 0;
                    Index2 += 1;
                }
                else
                {
                    Number = Index1 + Index2;
                    Index1 = Index2;
                    Index2 = Number;
                }
            }

            result = Number;
            return result;
        }
//Punto4
        public int MultiplesOfThreeInArray(int[] inputArr)
        {
            int result = 0;
            for ( int i = 0; i < inputArr.Length ; i++) {
                if ((inputArr[i]%3) == 0)
                {
                    result += 1;
                }
                               
            }
                    return result;
        }

        public bool NumberIsMultipleOf(int inputNum, int inputFactor)
        {
            bool result = false;
            if (inputNum % inputFactor == 0)
            {
                result = true;
            }
            return result;
        }

        public bool MatrixIsIdentity(int[,] inputMatrix)
        {
            bool result = false;

            return result;
        }

        public bool ElementsInDiagonalAreEqual(int[,] inputMatrix)
        {
            bool result = false;

            return result;
        }

        public int OperateElementsInArray(int[] inputArr)
        {
            int result = 0;
            if (inputArr.Length > 1)
            {
                for (int i = 0; i < inputArr.Length; i += 2)
                {
                    result += inputArr[i];
                }

                for (int i = 1; i < inputArr.Length; i += 2)
                {
                    result = result * inputArr[i];
                }
            }
            return result;
        }
//Punto 7 
        public int CountVowelsInString(string inputString)
        {
            int result = 0;
            for( int i =0; i < inputString.Length; i++)
            {
                if(inputString[i]== 'a')
                {
                    result += 1;
                }
                if (inputString[i] == 'e')
                {
                    result += 1;
                }
                if (inputString[i] == 'i')
                {
                    result += 1;
                }
                if (inputString[i] == 'o')
                {
                    result += 1;
                }
                if (inputString[i] == 'u')
                {
                    result += 1;
                }
                if (inputString[i] == 'é')
                {
                    result += 1;
                }
                if (inputString[i] == 'ú')
                {
                    result += 1;
                }
                if (inputString[i] == 'ó')
                {
                    result += 1;
                }
                if (inputString[i] == 'í')
                {
                    result += 1;
                }
                if (inputString[i] == 'á')
                {
                    result += 1;
                }
            }

            return result;
        }
//Punto 8 
        public int CountConsonantInString(string inputString)
        {
            int result = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if ((inputString[i] != 'a') && (inputString[i] != 'e') && (inputString[i] != 'i') && (inputString[i] != 'o') && (inputString[i] != 'u') && (inputString[i] != 'é'))
                {
                    result += 1;
                }

            }
                return result;
        }

        public string StringHasOddOrEvenCharCount(string inputString)
        {
            string result = string.Empty;
            if ((inputString.Length % 2) == 0)
            {
                result = "PAR";
            }
            else
            {
                result = "IMPAR";
            }
            //TODO: Para indicar que el conteo es par, retornar "PAR"
            //Para indicar que el conteo es inpar, retornar "IMPAR"

            return result;
        }

        public string ProductOfElementsIsOddOrEven(int[] inputArr)
        {
            string result = string.Empty;
            int Resultado = 1; 
            for (int i = 0; i < inputArr.Length; i++)
            {
                Resultado = Resultado * inputArr[i];
            }

            if ((Resultado % 2) == 0)
            {
                result = "PAR";
            }
            else
            {
                result = "IMPAR";
            }

            //TODO: Para indicar que el conteo es par, retornar "PAR"
            //Para indicar que el conteo es inpar, retornar "IMPAR"

            return result;
        }

        public string RacerGotFirst(float d1, float t1, float d2, float t2)
        {
            string result = string.Empty;
            float movimiento1 = 0.0f;
            float movimiento2 = 0.0f;

            movimiento1 = (d1 / t1);
            movimiento2 = (d2 / t2);

            if (movimiento1 > movimiento2)
            {
                result = "PRIMERO";
            }
            else
            {
                result = "SEGUNDO";
            }


            //TODO: Para indicar que el corredor más rápido es el primero, retornar "PRIMERO"
            //Para indicar que el corredor más rápido es el segundo, retornar "SEGUNDO"

            return result;
        }
    }
}