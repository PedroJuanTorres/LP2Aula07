using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observers
{
    public class FileSaver : IObserver<AbstractStringSubject>
    {
        private string file;
        public FileSaver(string file)
        {
            this.file = file;
        }
        public void Update(AbstractStringSubject sub)
        {
            File.AppendAllText(file, sub.Item);
        }
    }
}