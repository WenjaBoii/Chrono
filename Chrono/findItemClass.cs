using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrono
{
    internal class findItemClass
    {
        public static void moveToFront<T>(LinkedList<T> tasksList, T itemToMove)
        {
            if (tasksList == null)
            {
                return;
            }
            else
            {
                LinkedListNode<T> foundNode = tasksList.Find(itemToMove);

                if (foundNode != null)
                {
                    if (foundNode == tasksList.First)
                    {
                        return;
                    }
                    else
                    {
                        tasksList.Remove(foundNode);
                        tasksList.AddFirst(foundNode);
                    }
                }
                else
                {
                    return;
                }
            }
        }
        public static void setVisibility<T>(LinkedList<T> tasksList, Predicate<T> matchedItem, bool isVisibleState)
            where T : taskItemGraphics
        {
            foreach (var item in tasksList)
            {
                if (matchedItem(item))
                {
                    item.isVisibile = isVisibleState;
                    item.Visible = isVisibleState;
                }
            }   


        }   
        public static void showItem<T>(LinkedList<T> tasksList)
            where T : taskItemGraphics  
        {
            foreach (var item in tasksList)
            {
                item.Visible = true;    
            }
        }   

    }
}
