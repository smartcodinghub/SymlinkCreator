using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SymlinkCreator
{
    public class Symlink
    {
        public String Source { get; set; }
        public String Target { get; set; }
        public SymlinkOption SymlinkOption { get; set; }

        public Symlink()
        {

        }

        public Symlink(String source, String target, SymlinkOption symlinkOption)
        {
            this.Source = source;
            this.Target = target;
            this.SymlinkOption = symlinkOption;
        }

        public String CreateSymlink()
        {
            return $"mklink {this.SymlinkOption.Option} {this.Source} {this.Target}";
        }
    }
}
