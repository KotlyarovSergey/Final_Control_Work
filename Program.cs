string[] AddItem(string[] array, string item)
  {
      int oldSize = array.Length;
      string[] newArray = new string[oldSize + 1];
      for(int i = 0; i < oldSize; i++)
      {
          newArray[i] = array[i];
      }
      newArray[oldSize] = item;
      return newArray;
  }

  void Print(string[] array)
  {
      if(array.Length == 0) return;
      Console.Write(array[0]);
      for( int i = 1; i < array.Length; i++) 
          Console.Write(", " + array[i]);
      Console.WriteLine();
  }

  string[] userArray = new string[] {"One", "Two", "Three", "Four", "Five", "Six" , "Seven", "Eight", "Nine", "Ten"};
    if(userArray.Length == 0) return;
    
    Print(userArray);

    string[] myArray = new string[0];
    string text;
    
    for(int i = 0; i < userArray.Length; i++)
      {
          text = userArray[i];
          if (text.Length <= 3) 
          {
              myArray = AddItem(myArray, text);
          }
      }
   Print(myArray);