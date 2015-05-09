using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendu
{
    /// <summary>
    /// Provides a service to load words
    /// </summary>
    public interface IWordStorage
    {
        List<Word> Load();
    }
}
                                                                                    