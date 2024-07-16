public class Solution {
    public int CalPoints(string[] operations) {
          int sum = 0;
  List<int> points = new List<int>();

  for (int i = 0; i < operations.Length; i++)
  {
      if (operations[i] == "C")
      {
          if (points.Count > 0)
          {
              points.RemoveAt(points.Count - 1);
          }
      }
      else if (operations[i] == "D")
      {
          if (points.Count > 0)
          {
              points.Add(points[points.Count - 1] * 2);
          }
      }
      else if (operations[i] == "+")
      {
          if (points.Count > 1)
          {
              points.Add(points[points.Count - 1] + points[points.Count - 2]);
          }
      }
      else
      {
          points.Add(int.Parse(operations[i]));
      }
  }

  sum = points.Sum();
  Console.WriteLine(sum);
  return sum;
        }
    }
