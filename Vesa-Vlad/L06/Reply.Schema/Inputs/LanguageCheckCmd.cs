using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Domain.Inputs
{
    public class LanguageCheckCmd
    {
        public string TextToCheck { get; private set; }

        public LanguageCheckCmd(string textToCheck)
        {
            this.TextToCheck = textToCheck;
        }
    }
}
