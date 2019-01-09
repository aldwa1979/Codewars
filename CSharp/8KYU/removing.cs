public static class Kata
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            int lenght = arr.Length/2 + arr.Length%2;

            object[] arr2 = new object[lenght];
            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    j = i / 2;
                    arr2[j] = arr[i];
                }
            }
            return arr2;
        }
