namespace LeetCodePractice;

public class CustomHashTable
{
     private int[] hashTable;

     public CustomHashTable()
     {
          hashTable = new int[10];
     }

     private int hashKey(String key)
     {
          return key.Length % hashTable.Length;
     }

     public void put(String key, int data)
     {
          int hashedKey = hashKey(key);
          if (hashTable[hashedKey] != null)
          {
               Console.WriteLine("There is already a value in => " + hashedKey);
          }
          else
          {
               hashTable[hashedKey] = data;
          }
     }

     public int get(String key)
     {
          int hashedKey = hashKey(key);
          return hashTable[hashedKey];
     }

     public void printHashtable()
     {
          foreach (var item in hashTable)
          {
               Console.WriteLine(item);
          }
     }
}
