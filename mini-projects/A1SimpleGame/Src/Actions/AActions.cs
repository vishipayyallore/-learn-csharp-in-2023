using A1SimpleGame.Src.Text;

namespace A1SimpleGame.Src.Actions;

public sealed class AActions
{
    private AActions()
    {
    }

    private static readonly AActions _aActions = new();

    private readonly Dictionary<string, Action> _registeredActions = new();

    public static AActions Instance => _aActions;

    public void Register(Action action)
    {
        var name = action.Name.ToLower();

        if (!_registeredActions.ContainsKey(name))
        {
            _registeredActions.Add(name, action);
        }
        else
        {
            _registeredActions[name] = action;
        }
    }

    public void Execute(string[] args)
    {
        if (_registeredActions.TryGetValue(args[0], out Action? action))
        {
            action.Execute(args);
        }
        else
        {
            WriteLine(SpecifyText.Language.ActionError);
        }
    }
}
