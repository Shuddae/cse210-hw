using System;

public class BreathingActivity : Activity
{
   public BreathingActivity() : base(
        "Breathing",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public override void Perform()
    {
        Start();
        int elapsed = 0;

        while (elapsed < GetDuration())
        {
            Console.WriteLine("Breathe in...");
            Countdown(4);
            elapsed += 4;

            if (elapsed >= GetDuration()) break;

            Console.WriteLine("Breathe out...");
            Countdown(4);
            elapsed += 4;
        }

        End();
    }
}