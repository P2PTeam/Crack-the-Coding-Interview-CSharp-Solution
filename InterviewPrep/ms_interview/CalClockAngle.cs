using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.ms_interview
{
  class CalClockAngle
  {
    static void NotMain(String[] args)
    {
      double h = 6.00, m = 20;
      var result = calcAngle(h, m);
      Console.WriteLine("The result is: " + result.ToString());

      Console.Read();

    }

    public static Double calcAngle(double h, double m)
    {
      if (h < 0 || h > 12 || m < 0 || m > 60)
      {
        return 0;
      }

      // 0.5 per min for hour hand  360/12/60=0.5
      var hour_angle = 0.5 * (h * 60 + m);
      // 6 per min for min hand 360/60
      var  min_angle= 6*m;

      var angle = Math.Abs(min_angle - hour_angle);

      return Math.Min(angle, 360 - angle);
    }

  }
}
