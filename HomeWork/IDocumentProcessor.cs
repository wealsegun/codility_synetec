using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
   public interface IDocumentProcessor
    {/// <summary>
     /// Analyzes the document and returns statistics.
     /// </summary>
     /// <exception cref="ArgumentNullException">document is null</exception>
        Stats Analyze(string document);
    }
}
