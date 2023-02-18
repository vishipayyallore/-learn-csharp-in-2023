namespace A1SimpleGame.Src.Text;

public static class SpecifyText
{
    private static Language? _language = default;

    public static Language Language
    {
        get
        {
            if (_language is null)
            {
                throw new Exception("No language loaded.");
            }

            return _language;
        }
    }

    public static void LoadLanguage(Language language)
    {
        _language = language;
    }
}
