
DoSomething("Hello, World!");


var text2 = "";

static void DoSomething(string text, string CPF, string name)
{
    ArgumentNullException.ThrowIfNull(text);
    ArgumentNullException.ThrowIfNull(CPF);
    ArgumentNullException.ThrowIfNull(name);

    //text2 = text ?? new ArgumentNullException(nameof(text));
}