using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intense.Application
{
    public interface IQuery<TSearch, TResult>
    {
        TResult Execute(TSearch search);
    }
}
