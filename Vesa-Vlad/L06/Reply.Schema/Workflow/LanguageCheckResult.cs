using System;
using System.Collections.Generic;
using System.Text;

namespace Reply.Schema.Workflow
{
    public class LanguageCheckResult
    {
        public interface ILanguageCheckResult { }

        public class ValidText : ILanguageCheckResult
        {
            public string CheckedText { get; private set; }

            public ValidText(string checkedText)
            {
                this.CheckedText = checkedText;
            }
        }

        public class InvalidText : ILanguageCheckResult
        {
            public string ErrorMsg { get; private set; }

            public InvalidText(string errorMsg)
            {
                this.ErrorMsg = errorMsg;
            }
        }
    }
}
