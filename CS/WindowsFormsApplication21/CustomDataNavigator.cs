using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication21 {
    [ToolboxItem(true)]
    public class CustomDataNavigator : DataNavigator {
        public CustomDataNavigator()
            : base() {

        }
        protected override NavigatorButtonsBase CreateButtons() {
            return new CustomDataNavigatorButtons(this);
        }
    }
}
