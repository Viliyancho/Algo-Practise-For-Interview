// Given a string containing (){}[], determine if it is balanced.

string sequence = Console.ReadLine();

if(sequence.Length % 2 != 0)
{
    throw new Exception();
}

int half = sequence.Length / 2;

for(int i = 0; i < half; i++)
{
	switch (sequence[i])
	{
		case '(':
			if (sequence[sequence.Length - 1 - i] != ')')
			{
                Console.WriteLine("It is not balanced!");
				return;
			}
			break;
        case ')':
            if (sequence[sequence.Length - 1 - i] != '(')
            {
                Console.WriteLine("It is not balanced!");
                return;
            }
            break;
        case '{':
            if (sequence[sequence.Length - 1 - i] != '}')
            {
                Console.WriteLine("It is not balanced!");
                return;
            }
            break;
        case '}':
            if (sequence[sequence.Length - 1 - i] != '{')
            {
                Console.WriteLine("It is not balanced!");
                return;
            }
            break;
        case '[':
            if (sequence[sequence.Length - 1 - i] != ']')
            {
                Console.WriteLine("It is not balanced!");
                return;
            }
            break;
        case ']':
            if (sequence[sequence.Length - 1 - i] != '[')
            {
                Console.WriteLine("It is not balanced!");
                return;
            }
            break;
        default:
            Console.WriteLine("There is a different symbol from the allowed!");
			break;
	}
}

Console.WriteLine("The sequence is balanced!");