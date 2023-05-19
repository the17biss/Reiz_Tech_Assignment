using System;

class Program
{
    static double CalculateAngle(int hours, int minutes)
    {
        // Converting hours to 12-hour format
        hours %= 12;
        /* The angle covered by minute hand is calculated as:
        * total angle covered by clock = 360
        * total minutes in a complete hour = 60
        * so, each minute mark = 360/60 = 6
        */
        double minuteAngle = minutes * 6;

        /* The angle covered by hour is calculated as:
         * Since we have tweleve hours in a clock which is a perfect circle having complete angle of 360 degrees.
         * So each hour mark = 360/12 = 30 degrees
         * But hour position is influenced by the minutes position too so:
         * actual hour angle is equal to sum of hour *30 + minutes * 30/60..
         */

        double hourAngle = (hours * 30) + (minutes * 0.5);


        // Calculating the absolute difference between the two angles which gives the angle between the hour hand and minute hand
        double angle = Math.Abs(hourAngle - minuteAngle);

        // Calculating the lesser angle (360 - angle) when the angle is greater than 180 degrees
        if (angle > 180)
        {
            angle = 360 - angle;
        }

        return angle;
    }

    static void Main()
    {
        // Asking for user input about hour mark and minute mark:
        Console.Write("Enter the hours (0-23): ");
        int hours = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the minutes (0-59): ");
        int minutes = Convert.ToInt32(Console.ReadLine());

        // Calculating the lesser angle by calling the method defined above:
        double angle = CalculateAngle(hours, minutes);

        // Output the result
        Console.WriteLine($"The lesser angle between the hour and minute hands is {angle} degrees.");
    }
}