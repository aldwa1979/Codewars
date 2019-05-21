using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class WeightSort {
	
	public static string orderWeight(string strng) {
		        
            var weight = strng.Split(' ').ToArray();
            var weightList = new List<Weight>();
            var sum = 0;

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < weight.Length; i++)
            {
                for (int j = 0; j < weight[i].Length; j++)
                {
                    sum += Convert.ToInt32(weight[i].ElementAt(j).ToString());
                }
                weightList.Add(new Weight (sum, weight[i]));
                sum = 0;
            }

            var lista_posortowana = weightList.OrderBy(x => x.weightIndex).ThenBy(x => x.weightData);

            var string_lista = lista_posortowana.Select(x => x.weightData).ToArray();

            foreach (var item in string_lista)
            {
                builder.Append(item + " ");
            }
            return builder.ToString().TrimEnd(' ');
	}
}

class Weight
    {
        public Weight(int weightIndex, string weightData)
        {
            this.weightIndex = weightIndex;
            this.weightData = weightData;
        }

        public int weightIndex { get; set; }
        public string weightData { get; set; }
    }
