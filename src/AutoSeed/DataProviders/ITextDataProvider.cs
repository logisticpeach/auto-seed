using System;
using System.Collections.Generic;
using System.Text;

namespace AutoSeed.DataProviders
{
    public interface ITextDataProvider
    {
        string GetWords(int wordCount);

        string GetParagraphs(int paragraphCount);
    }
}
