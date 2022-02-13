// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool x = true;
bool y = true;
if (!(x || y) == (!x && !y))
{
    Console.Write("True");
}
else
Console.Write("False");