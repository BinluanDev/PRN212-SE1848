void swap(ref int x, ref int y) {
    int temp = x;
        x = y;
    y = temp;

}
void sort_array(int []arr) {
    for (int i = 0; i < arr.Length; i++) {
        for (int j = i + 1; j < arr.Length; j++) {
            if (arr[i] > arr[j]) {
                swap(ref arr[i],ref arr[j]);
            }
    }
}

void create_array(int []values)
    {
        Random rd = new Random();
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = rd.Next(100);
        }
    }
void print_array(int []values)
    {
        foreach (int value in values)
        {
            Console.Write($"{value}\t");
        }
}
    create_array(values);
    print_array(values);
    sort_array(arr);
    Console.WriteLine("\nAFTER SORTING: ");
    print_array(values);

void sort_array(int[] arr) {
        int i = 0;
        while (i < arr.Length) {
            i++;
        }
    }