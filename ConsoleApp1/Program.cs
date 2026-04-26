
        Console.Write("Enter 1st number: ");
        double angka1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("enter operator (+, -, *, /): ");
        string op = Convert.ToString(Console.ReadLine());

        Console.Write("enter 2nd num: ");
        double angka2 = Convert.ToDouble(Console.ReadLine());

        double hasil = 0;

        switch (op)
        {
            case "+":
                hasil = angka1 + angka2;
                break;

            case "-":
                hasil = angka1 - angka2;
                break;

            case "*":
                hasil = angka1 * angka2;
                break;

            case "/":
                if (angka2 != 0)
                    hasil = angka1 / angka2;
                else
                {
                    Console.WriteLine("Cannot divided by 0");
                    return;
                }
                break;

            default:
                Console.WriteLine("Unknown Operator");
                return;
        }

        Console.WriteLine($"Hasil: {hasil}");
    









