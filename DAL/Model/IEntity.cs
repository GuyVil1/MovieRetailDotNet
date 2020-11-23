using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public interface IEntity<TKey>
    {
        TKey Id { get; }
    }
}
