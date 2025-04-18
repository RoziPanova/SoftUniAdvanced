using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SharkTaxonomy
{
    public class Classifier
    {
        public int Capacity { get; set; }
        public List<Shark> Species { get; set; }
        public int GetCount { get { return Species.Count; } }
        public Classifier(int capacity)
        {
            Capacity = capacity;
            Species = new List<Shark>();
        }
        public void AddShark(Shark shark)
        {
            if (Species.Count < Capacity)
            {
                Species.Add(shark);
            }
        }
        public bool RemoveShark(string kind)
        {
            var shark = Species.Find(x => x.Kind == kind);
            if (shark != null)
            {
                Species.Remove(shark);
                Console.WriteLine("True");
                return true;
            }
            Console.WriteLine("False");
            return false;
        }
        public string GetLargestShark()
        {
            return Species.Max(x => x.Length).ToString();
        }
        public double GetAverageLength()
        {
            return Species.Average(x => x.Length);
        }
        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{Species.Count} sharks classified:");
            for (int s = 0; s < Species.Count; s++)
            {

                stringBuilder.AppendLine($"{Species[s].ToString()}");
            }

            return stringBuilder.ToString().Trim();
        }
    }
}
