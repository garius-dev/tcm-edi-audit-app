using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcm_edi_audit_core_new.Extensions
{
    public static class ControlsExtensions
    {
        public static void SetCheckState(this Button button, bool isChecked, Image checkedImage, Image uncheckedImage)
        {
            if (button == null) return;

            button.Tag = isChecked ? "1" : "0";
            button.Image = isChecked ? checkedImage : uncheckedImage;
        }

        public static bool GetCheckState(this Button button)
        {
            if (button?.Tag != null && button.Tag.ToString() == "1")
                return true;

            return false;
        }

        public static void SwapCheckState(this Button button, Image checkedImage, Image uncheckedImage)
        {
            bool currentState = button.GetCheckState();
            button.SetCheckState(!currentState, checkedImage, uncheckedImage);
        }
    }
}
