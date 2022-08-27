using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.AceEditorJs
{
    public class AceEditorOptions
    {
        public AceLanguage Language { get; set; } = AceLanguage.text;
        public AceTheme Theme { get; set; } = AceTheme.sqlserver;
        public bool IsReadOnly { get; set; } = false;
    }
}
