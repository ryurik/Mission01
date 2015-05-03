using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fittings
{
    public class Store : ICollection<IBaseItem>
    {
        private ICollection<IBaseItem> _mediaItems = new List<IBaseItem>();

        #region ICollection<IBaseItem>
        public void Add(IBaseItem item)
        {
            _mediaItems.Add(item);
        }

        public void Clear()
        {
            _mediaItems.Clear();
        }

        public bool Contains(IBaseItem item)
        {
            return _mediaItems.Contains(item);
        }

        public void CopyTo(IBaseItem[] array, int arrayIndex)
        {
            _mediaItems.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _mediaItems.Count; }
        }

        public bool IsReadOnly
        {
            get { return _mediaItems.IsReadOnly; }
        }

        public bool Remove(IBaseItem item)
        {
            return _mediaItems.Remove(item);
        }

        public IEnumerator<IBaseItem> GetEnumerator()
        {
            return _mediaItems.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion

        protected void Sort(IComparer<IBaseItem> comparer)
        {
            var newList = _mediaItems.ToList();
            newList.Sort(comparer);
            _mediaItems = newList;
        }

        public void SortByIncomeDate()
        {
            Sort(new ItemsComparerByIncomeDate());
        }

        public IEnumerable<IBaseItem> GetMediaItems(DateTime startDate, DateTime endDate)
        {
            foreach (var i in _mediaItems)
            {
                if (i.IncomeDate >= startDate && i.IncomeDate <= endDate)
                {
                    yield return i;
                }
            }
        }
    }
}
