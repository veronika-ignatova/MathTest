Console.WriteLine("Hi! Print X and Y for each point of the square and also for a new point");
try
{
    Console.WriteLine("Print X1 of first point: ");
    double firstPointX = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Print Y1 of first point: ");
    double firstPointY = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Print X2 of second point: ");
    double secondPointX = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Print Y2 of second point: ");
    double secondPointY = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Print X3 of third point: ");
    double thirdPointX = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Print Y3 of third point: ");
    double thirdPointY = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Print X4 of fourth point: ");
    double fourthPointX = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Print Y4 of fourth point: ");
    double fourthPointY = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Print X of the point: ");
    double pointX = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Print Y of the point: ");
    double pointY = Convert.ToDouble(Console.ReadLine());


    double length(double x1, double y1, double x2, double y2)
    {
        double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        return length;
    }

    //double p(double a, double b, double c)
    //{
    //    double p = (a+b+c)/2;
    //    return p;
    //}

    double S(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return S;
    }

    double AB = length(firstPointX, firstPointY, secondPointX, secondPointY);
    double BC = length(secondPointX, secondPointY, thirdPointX, thirdPointY);
    double CD = length(thirdPointX, thirdPointY, fourthPointX, fourthPointY);
    double AD = length(firstPointX, firstPointY, fourthPointX, fourthPointY);
    double AM = length(firstPointX, firstPointY, pointX, pointY);
    double BM = length(secondPointX, secondPointY, pointX, pointY);
    double CM = length(thirdPointX, thirdPointY, pointX, pointY);
    double DM = length(fourthPointX, fourthPointY, pointX, pointY);
    double AC = length(firstPointX, firstPointY, thirdPointX, thirdPointY);
    double BD = length(secondPointX, secondPointY, fourthPointX, fourthPointY);
    double SquareS = AB * AB;
    double S1 = S(AB, AM, BM);
    double S2 = S(BC, BM, CM);
    double S3 = S(CD, CM, DM);
    double S4 = S(AD, AM, DM);

    if ((AB == BC) && (BC == CD) && (CD == AD) && (AD == AB) && (AC == BD) && (AB != 0))
    {
        if (S1 + S2 + S3 + S4 == SquareS)
        {
            Console.WriteLine("Point is in square!");
        }
        else
        {
            Console.WriteLine("Point isn`t in square!");
        }
    }
    else
    {
        Console.WriteLine("This is not a square! Please try again :)");
    }
}
catch (FormatException)
{
    Console.WriteLine("Invalid input. Please try again!");
}