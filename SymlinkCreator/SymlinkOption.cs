using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SymlinkCreator
{
    public class SymlinkOption
    {
        public static readonly SymlinkOption FILE_SYMBOLIC = new SymlinkOption("", "File Symbolic Link [Default]");
        public static readonly SymlinkOption FILE_HARD = new SymlinkOption("/H", "File Hard Link [/H]");

        public static readonly SymlinkOption DIRECTORY_SYMBOLIC = new SymlinkOption("/D", "Directory Symbolic Link [/D]");
        public static readonly SymlinkOption DIRECTORY_HARD = new SymlinkOption("/J", "Directory Hard Link [/J]");

        public static readonly SymlinkOption[] Values = new SymlinkOption[] { FILE_SYMBOLIC, FILE_HARD, DIRECTORY_SYMBOLIC, DIRECTORY_HARD };

        public String Option { get; }
        public String Text { get; }

        private SymlinkOption(String option, String text)
        {
            this.Option = option;
            this.Text = text;
        }

        public override string ToString() => this.Text;
    }
}
