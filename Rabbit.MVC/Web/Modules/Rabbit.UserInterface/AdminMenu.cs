using Rabbit.Kernel.Localization;
using Rabbit.Web.UI.Navigation;

namespace Rabbit.UserInterface
{
    internal sealed class AdminMenu : INavigationProvider
    {
        public AdminMenu()
        {
            T = NullLocalizer.Instance;
        }

        public Localizer T { get; set; }

        #region Implementation of INavigationProvider

        /// <summary>
        /// ��ȡ������
        /// </summary>
        /// <param name="builder">���������ߡ�</param>
        public void GetNavigation(NavigationBuilder builder)
        {
            const string area = "Rabbit.UserInterface";
            builder.Add(T("����̨"),
                menu =>
                    menu
                        .Position("1")
                        .LocalNavigation()
                        .Icon("fa fa-fw fa-dashboard")
                        .Add(T("��ҳ"), i => i.Action("Index", "Admin", new { Area = area }).LocalNavigation())
                        .Add(T("User List"), i => i.Action("UserList", "User", new { Area = area }).LocalNavigation())
                        .Add(T("User Profile"), i => i.Action("UserProfile", "User", new { Area = area }).LocalNavigation())
                        .Add(T("Media"), i => i.Action("Media", "Admin", new { Area = area }).LocalNavigation())
                );
        }

        /// <summary>
        /// �����˵����ơ�
        /// </summary>
        public string MenuName { get { return "admin"; } }

        #endregion Implementation of INavigationProvider
    }
}