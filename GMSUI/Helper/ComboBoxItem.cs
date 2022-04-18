using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMSUI.Helper;
internal class ComboBoxItem<T>{
    public string Label { get; set; }
    public T Value { get; set; }

    public override string ToString() {
        return $"{Value}";
    }
}
