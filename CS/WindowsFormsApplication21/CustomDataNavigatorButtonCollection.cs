using DevExpress.XtraEditors;
using DevExpress.XtraEditors.NavigatorButtons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication21 {
    public class CustomDataNavigatorButtonCollection : DataNavigatorButtonCollection {
        public CustomDataNavigatorButtonCollection(DataNavigatorButtons buttons)
            : base(buttons) {
        }
        protected override void CreateButtons(NavigatorButtonsBase buttons) {
            AddButton(new DataNavigatorFirstButtonHelper(buttons));
            AddButton(new DataNavigatorPrevPageButtonHelper(buttons));
            AddButton(new DataNavigatorPrevButtonHelper(buttons));
            AddButton(new DataNavigatorNextButtonHelper(buttons));
            AddButton(new DataNavigatorNextPageButtonHelper(buttons));
            AddButton(new DataNavigatorLastButtonHelper(buttons));
            AddButton(new DataNavigatorAddButtonHelper(buttons));
            AddButton(new DataNavigatorRemoveButtonHelper(buttons));
            AddButton(new DataNavigatorCancelEditButtonHelper(buttons));
            AddButton(new DataNavigatorEndEditButtonHelper(buttons));
        }
    }
}
