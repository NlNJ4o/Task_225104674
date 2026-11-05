// Name: < Mustafa Mustafa Awad >
// Student ID: < 225104674 >

using System.Text;

namespace Cse111Task1;


public class StudentList
{
    public Student? First;
    public Student? Last;
    public int Count;

    
    public void AddFront(int id)
    {
        var node = new Student(id);
        node.Next = First;         
        First = node;              
        if (Last == null)          
            Last = node;
        Count++;
    }

  
    public void AddEnd(int id)
    {
        var node = new Student(id);
        if (Last == null)          
        {
            First = node;
        }
        else
        {
            Last.Next = node;      
        }
        Last = node;               
        Count++;
    }


    public bool Remove(int id)
    {
        Student? prev = null;      
        Student? cur = First;

     
        while (cur != null && cur.Id != id)
        {
            prev = cur;
            cur = cur.Next;
        }

        
        if (cur == null)
            return false;

       
        if (prev == null)
        {
        
            First = cur.Next;
        }
        else
        {
        
            prev.Next = cur.Next;
        }

       
        if (cur == Last)
            Last = prev;

        cur.Next = null;           
        Count--;
        return true;
    }

   
    public void Reverse()
    {
        Last = First;              

        Student? prev = null;       
        Student? cur = First;

        while (cur != null)
        {
            Student? next = cur.Next;   
            cur.Next = prev;
            prev = cur;                 
            cur = next;               
        }

        First = prev;          
        
    }

  
    public void Print()
    {
        var sb = new StringBuilder();
        for (Student? cur = First; cur != null; cur = cur.Next)
        {
            if (sb.Length > 0) sb.Append(' ');
            sb.Append(cur.Id);
        }
        Console.WriteLine(sb.ToString());
    }
}
