namespace Domain.Repositories.Interfaces;

public interface IThemeHandler {
    MudTheme Theme { get; set; }
    bool ThemeMenuShown { get; set; }
    bool DarkMode { get; set; }
    bool SideOpenMini { get; set; }
    bool SideOpen { get; set; }
    ESideMenuState ESideMenuState { get; set; }

    event Action ThemeChange;
    void UpdateMode(bool darkMode);
    void UpdateSideMenu(ESideMenuState state);
    void UpdateThemeMenu(bool shown);
    void UpdateTheme(MudTheme theme);
    void UpdatePrimary(MudColor color);
    void UpdateSecondary(MudColor color);

    void UpdateAll(Theme theme);
}