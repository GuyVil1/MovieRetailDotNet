using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public interface IEntity<TKey>
    {
        TKey Id { get; }
    }
}
