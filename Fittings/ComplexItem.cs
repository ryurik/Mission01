using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fittings
{
    public class ComplexItem : ICollection<IPartsItem>
    {

        public TimeSpan Duration { get; set; }
        public DateTime CreationDate { get; set; }
        public TypeOfParts TypeOfPart { get; set; }
        public string Name { get; set; }

        private ICollection<IPartsItem> _items = new List<IPartsItem>();

        #region ICollection<IPartsItem>
        public void Add(IPartsItem item)
        {
            _items.Add(item);
        }

        public void Clear()
        {
            _items.Clear();
        }

        public bool Contains(IPartsItem item)
        {
            return _items.Contains(item);
        }

        public void CopyTo(IPartsItem[] array, int arrayIndex)
        {
            _items.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public bool IsReadOnly
        {
            get { return _items.IsReadOnly; }
        }

        public bool Remove(IPartsItem item)
        {
            return _items.Remove(item);
        }

        public IEnumerator<IPartsItem> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        #endregion

    }
}
