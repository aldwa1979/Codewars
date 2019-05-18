class WhichAreIn
        {
            public static string[] inArray(string[] array1, string[] array2)
            {
            
           List<string> l3 = new List<string>();

            for (int i = 0; i < array2.Length ; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array2[i].Contains(array1[j]))
                    {
                        l3.Add(array1[j]);
                    }
                }
            }

            var l4 = l3.Distinct().ToList();
            l4.Sort();

                return l4.ToArray();
            }
        }
