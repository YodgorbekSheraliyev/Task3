using System.Numerics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

var app = builder.Build();
app.MapGet("/yodgorbeksheraliyev____gmail_com", (string? x, string? y) =>
{

    if(!IsValidNumber(x) || !IsValidNumber(y))
        return "NaN";
    BigInteger a = BigInteger.Parse(x!);
    BigInteger b = BigInteger.Parse(y!);

    BigInteger gcd = BigInteger.GreatestCommonDivisor(a, b);
    BigInteger lcm = (a * b ) / gcd ;

    return lcm.ToString();

});

app.Run();

static bool IsValidNumber(string value)
{
    if (string.IsNullOrEmpty(value))
        return false;

    foreach (char c in value)
    {
        if (c < '0' || c > '9')
            return false;
    }

    return BigInteger.TryParse(value, out var n) && n > 0;
}
