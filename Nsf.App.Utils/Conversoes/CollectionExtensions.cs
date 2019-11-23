using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.UI
{
    public static class CollectionExtensions
    {
        public static void UpdateList<T>(this BindingList<T> obj, List<T> itens)
        {
            obj.Clear();
            itens.ForEach(x => obj.Add(x));
        }

		public static void UpdateList<T>(this BindingList<T> obj, List<T> itens, Func<T, IComparable> orderBy)
        {
            obj.Clear();
            itens.ForEach(x => obj.Add(x));

			obj.OrderBy(i => orderBy);
        }

        public static void AppendList<T>(this BindingList<T> obj, List<T> itens)
        {
            itens.ForEach(x => obj.Add(x));
        }
    }
}
