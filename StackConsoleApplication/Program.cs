using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackConsoleApplication
{
    class Node
    {
        public char Data { get; set; }
        public Node Next { get; set; }
    }
    class stack
    {
        Node Top;
        public void push(char item)
        {
            Node newnode = new Node();
            newnode.Data = item;
            if (Top == null)
            {
                Top = newnode;
            }
            else
            {
                newnode.Next = Top;
                Top = newnode;
            }
        }
        public char pop()
        {
            char kp = Top.Data;
            Top = Top.Next;
            return kp;
        }
        public bool isEmpty()
        {
            return (Top == null);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            stack st = new stack();
            string bieuthuc = "((8+7)-(8-9))";
            //Console.WriteLine("moi nhap bieu thuc");
            //bieuthuc = Console.ReadLine();//}({8+7)-(8-9)]
            for (i = 0; i < bieuthuc.Length; i++)
            {
                if (bieuthuc[i] == '{' || bieuthuc[i] == '(')
                {
                    st.push(bieuthuc[i]);
                }
                else if (bieuthuc[i] == '}' || bieuthuc[i] == ')')
                {
                    if (st.isEmpty())
                    {
                        break;
                    }
                    char kq = st.pop();
                    if (!((kq == '(' && bieuthuc[i] == ')') || (kq == '{' && bieuthuc[i] == '}')))
                    {
                        // Console.WriteLine("bieu thuc khong hop le");
                        break;
                    }
                }
            }
            if (st.isEmpty() && i == bieuthuc.Length)
            {
                Console.WriteLine("bieu thuc hop le ");
            }
            else
            {
                Console.WriteLine("bieu thuc k hop the ");
            }
            Console.ReadLine();
        }
    }
}
