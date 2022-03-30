namespace View;

public class CircuitTracker : CircuitHandler {
    private readonly ProtectedLocalStorage _local;

    private readonly IThemeHandler _theme;

    public CircuitTracker(IThemeHandler theme, ProtectedLocalStorage local) {
        _theme = theme;
        _local = local;
    }

    public override async Task OnConnectionUpAsync(Circuit circuit, CancellationToken cancellationToken) {
        await GetStuff();
    }

    private async Task GetStuff() {
        var theme = (await _local.GetAsync<Theme>("Theme")).Value;
        if (theme is null) return;

        _theme.UpdateAll(theme);
    }
}