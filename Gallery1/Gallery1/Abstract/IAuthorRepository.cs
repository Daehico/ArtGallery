using Gallery1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery1.Abstract
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> Authors { get; }
    }
}
