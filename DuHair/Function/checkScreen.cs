using System;
using System.Collections.Generic;
using System.Text;

namespace DuHair
{
    public static class checkScreen
    {
        static CheckForm check = null;
        public static void showCheck()
        {
            if (check == null)
            {
                check = new CheckForm();
                check.showCheck();
            }
        }

        public static void closeCheck()
        {
            if (check != null)
            {
                check.closeCheck();
                check = null;
            }
        }
        public static void updateStatus(string message)
        {
            if (check != null)
                check.updateStatus(message);
        }
    }
}
