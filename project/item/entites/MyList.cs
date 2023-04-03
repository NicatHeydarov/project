using System.Collections;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace item.entites;

internal class MyList<T> : IEnumerable<T>
{
    public int Capacity { get; set; }
    public int Count { get; set; }
   public T[] Array { get; set; }

    public MyList(int capacity)    
    {
        Capacity = capacity;
    }
    public void Add(object item)
    {   
        item=null;
    }

    
    public T this[int index]
    {
        get { return Array[index]; }
        set { Array[index] = value; }
    }
    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
    void PrintMessageReverse(string message) 
    {
        char[] chars = message.Reverse().ToArray();
        String newStr = new String(chars);
        Console.WriteLine(newStr);
    }
  
}
