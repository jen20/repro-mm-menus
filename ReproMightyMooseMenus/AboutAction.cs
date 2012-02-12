using System.Windows.Forms;
using JetBrains.ActionManagement;
using JetBrains.Application.DataContext;

namespace ReproMightyMooseMenus
{
    [ActionHandler("ReproMightyMooseMenus.About")]
    public class AboutAction : IActionHandler
    {
        #region IActionHandler Members

        public bool Update(IDataContext context, ActionPresentation presentation, DelegateUpdate nextUpdate)
        {
            // return true or false to enable/disable this action
            return true;
        }

        public void Execute(IDataContext context, DelegateExecute nextExecute)
        {
            MessageBox.Show(
                "Repro Plugin\nN/A\n\nTest",
                "About Repro Plugin",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        #endregion
    }
}