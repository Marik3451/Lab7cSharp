using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6cSharp
{
    public class WolfCollection : IEnumerable<IAnimal>, IEnumerable
    {
        private ArrayList list = new ArrayList();

        public int Count => list.Count;

        public IAnimal this[int index]
        {
            get
            {
                if (index < 0 || index >= list.Count)
                {
                    throw new ArgumentOutOfRangeException("index", "Index is out of range.");
                }
                return (IAnimal)list[index];
            }
        }

        public void Push(IAnimal item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item", "Item cannot be null.");
            }
            list.Add(item);
        }

        public IAnimal Pop()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("List is empty.");
            }
            int lastIndex = list.Count - 1;
            IAnimal item = (IAnimal)list[lastIndex];
            list.RemoveAt(lastIndex);
            return item;
        }

        public IAnimal Peek()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("List is empty.");
            }
            return (IAnimal)list[list.Count - 1];
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(IAnimal item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item", "Item cannot be null.");
            }
            return list.Contains(item);
        }

        public void CopyTo(IAnimal[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array", "Array cannot be null.");
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("arrayIndex", "Index is out of range.");
            }
            if (arrayIndex + list.Count > array.Length)
            {
                throw new ArgumentException("The number of elements in the source collection is greater than the available space in the destination array.");
            }
            list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<IAnimal> GetEnumerator()
        {
            return (IEnumerator<IAnimal>)list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class WolfCollection<T> : IList<T> where T : IAnimal
    {
        private List<T> list = new List<T>();

        public T this[int index]
        {
            get { return list[index]; }
            set { throw new InvalidOperationException(); }
        }

        public int Count
        {
            get { return list.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return list.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            list.Insert(index, item);
        }

        public bool Remove(T item)
        {
            return list.Remove(item);
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
