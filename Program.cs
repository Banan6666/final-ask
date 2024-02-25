string[] FormatString (string[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i].Length <= 3){
            count++;
        }
    }
    string[] arr = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i].Length <= 3){
            arr[j] = array[i];
            j++;
        }
    }

    return arr;
}
string[] array = {"Hello", "2", "world", ":-)"};
Console.WriteLine($"[{string.Join("; ", FormatString(array))}]");