using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication21 {
    public class CustomDataNavigatorButtons : DataNavigatorButtons {
        public CustomDataNavigatorButtons(INavigatorOwner owner)
            : base(owner) {

        }
        protected override NavigatorButtonCollectionBase CreateNavigatorButtonCollection() {
            return new CustomDataNavigatorButtonCollection(this);
        }
    }
}
